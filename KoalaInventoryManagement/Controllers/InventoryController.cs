using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.Services;
using KoalaInventoryManagement.Services.Filteration;
using KoalaInventoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize]
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductFilterService _productFilter;
        private static List<ProductViewModel> _ProductsAfterFilter = new List<ProductViewModel>();

        public InventoryController(IUnitOfWork unitOfWork, IProductFilterService productFilter)
        {
            _unitOfWork = unitOfWork;
            _productFilter = productFilter;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            // Get the role from session
            var userRole = HttpContext.Session.GetString("UserRole");

            // Extract the warehouse ID from the role (e.g., 'WHManager1' -> 1)
            int warehouseId = 0;
            if (userRole != null && userRole.StartsWith("WHManager"))
                int.TryParse(userRole.Substring("WHManager".Length), out warehouseId);

            List<ProductViewModel> productsViewModel = _productFilter.ProductsPerRole(warehouseId);

            ViewBag.AllWareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>();
            ViewBag.AllSuppliers = _unitOfWork?.Suppliers?.GetAllAsync().Result?.ToList() ?? new List<Supplier>();
            ViewBag.AllCategories = _unitOfWork?.Categories?.GetAllAsync().Result?.ToList() ?? new List<Category>();
            ViewBag.WareHouseManagerID = warehouseId > 0 ? warehouseId : 0;


            var paginatedProducts
                = productsViewModel.Skip((page - 1) * pageSize).Take(pageSize).DistinctBy(p => p.Id).ToList();

            // Pass pagination metadata to the view
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling(productsViewModel.Count / (double)pageSize);

            return View(paginatedProducts);
        }

        #region Filteration
        [HttpPost]
        public IActionResult GetFilteredProducts(int wareHouseID, int categoryID, int supplierID, string searchString, int page = 1, int pageSize = 10)
        {
            ViewBag.SelectedWareHouse = wareHouseID;
            ViewBag.SelectedCategory = categoryID;
            ViewBag.SelectedSupplier = supplierID;

            string? userRole = HttpContext.Session.GetString("UserRole");

            // Filter the products using the filtration service
            List<ProductViewModel> filteredProducts
                = _productFilter?.FilterData(wareHouseID, categoryID, supplierID, searchString, userRole ?? string.Empty)
                    ?? new List<ProductViewModel>();

            //Getting Filtered Products to be fetched in Reports
            _ProductsAfterFilter.Clear();
            _ProductsAfterFilter.AddRange(filteredProducts);

            var paginatedProducts = filteredProducts.Skip((page - 1) * pageSize).Take(pageSize).DistinctBy(p => p.Id).ToList();

            return Json(new
            {
                products = paginatedProducts,
                currentPage = page,
                totalPages = (int)Math.Ceiling(filteredProducts.Count / (double)pageSize),
                role = userRole
            });
        }
        #endregion

        #region CRUD Operations
        [HttpPost]
        public IActionResult AddProduct(Product newProduct, WareHouseProduct wareHouseProduct, IFormFile file)
        {
            #region Handling Image
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var fileExtension = Path.GetExtension(fileName);

                // Ensure that the uploaded file is an image
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!allowedExtensions.Contains(fileExtension.ToLower()))
                {
                    return BadRequest("Only image files (.jpg, .jpeg, .png, .gif) are allowed.");
                }

                // Convert the file to byte array
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    newProduct.Image = memoryStream.ToArray();
                }
            }
            #endregion

            #region Saving To Database
            if (newProduct == null)
            {
                return BadRequest("Product information is required.");
            }

            if (_unitOfWork?.Products?.Add(newProduct) ?? false)
            {
                _unitOfWork?.Complete();
                wareHouseProduct.ProductID = newProduct.Id;

                if (_unitOfWork?.WareHousesProducts?.Add(wareHouseProduct) ?? false)
                {
                    _unitOfWork?.Complete();
                }
                return RedirectToAction("Index");
            }
            #endregion

            return StatusCode(500, "Failed to add the product."); // Or handle more gracefully
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            string role = (HttpContext?.Session?.GetString("UserRole") ?? "");
            if (role == "Admin")
            {
                //Delete from all warehouses
                if (_unitOfWork?.Products?.Delete(id) ?? false)
                {
                    _unitOfWork?.Complete();
                    return RedirectToAction("Index");
                }
            }
            else if (role.StartsWith("WHManager"))
            {
                int warehouseId = 0;
                int.TryParse(role.Substring("WHManager".Length), out warehouseId);

                if (warehouseId > 0)
                {
                    // only empty warehouse stocks from the product 
                    WareHouseProduct? existingWHP = _unitOfWork?.WareHousesProducts?.GetWareHouseProduct(id, warehouseId);
                    if (existingWHP != null)
                    {
                        existingWHP.CurrentStock = 0;
                        existingWHP.MinStock = 0;
                        existingWHP.MaxStock = 0;
                        _unitOfWork?.Complete();
                        return RedirectToAction("Index");
                    }
                }
            }

            return NotFound($"Product with ID {id} not found."); // Provide feedback if deletion fails
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product editedProduct, IFormFile file)

        {
            if (editedProduct == null)
            {
                return BadRequest("Product information is required.");
            }

            // Retrieve the existing product from the database
            Product? existingProduct = _unitOfWork?.Products?.GetbyId(editedProduct.Id);
            if (existingProduct != null)
            {
                // Check if a new image file is provided
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var fileExtension = Path.GetExtension(fileName);
                    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

                    // Ensure the uploaded file is an image
                    if (allowedExtensions.Contains(fileExtension.ToLower()))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            file.CopyTo(memoryStream);
                            existingProduct.Image = memoryStream.ToArray(); // Update the image
                        }

                        // Update the existing product
                        existingProduct.Name = editedProduct.Name;
                        existingProduct.Price = editedProduct.Price;
                        existingProduct.Description = editedProduct.Description;
                        existingProduct.SupplierId = editedProduct.SupplierId;
                        existingProduct.CategoryId = editedProduct.CategoryId;

                        _unitOfWork?.Complete();
                    }
                    else
                    {
                        return BadRequest("Only image files (.jpg, .jpeg, .png, .gif) are allowed.");
                    }
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Details Management
        [HttpGet]
        public IActionResult ShowDetails(int id)
        {
            Product? product
                = _unitOfWork?.Products?.GetbyId(id, ["Supplier", "Category"]) ?? new Product();

            List<WareHouseProduct> prdWareHouses
                = _unitOfWork?.WareHousesProducts?
                              .GettWareHousesProductsByPrdID(id, ["WareHouse"])?
                              .ToList() ?? new List<WareHouseProduct>();

            var userRole = HttpContext.Session.GetString("UserRole");

            int warehouseId = 0;
            if (userRole != null && userRole.StartsWith("WHManager"))
            {
                int.TryParse(userRole.Substring("WHManager".Length), out warehouseId);
                if (warehouseId > 0)
                {
                    prdWareHouses = prdWareHouses.Where(whp => whp.WareHouseID == warehouseId).ToList();
                }
            }

            int productQuantity = 0;
            foreach (int currentStock in prdWareHouses.Select(whp => whp.CurrentStock))
            {
                productQuantity += currentStock;
            }

            ProductDetailsVM productDetails = new ProductDetailsVM()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image,
                Quantity = productQuantity,
                ProductWareHouses = prdWareHouses,
                CategoryName = product?.Category?.Name ?? string.Empty,
                SupplierName = product?.Supplier?.Name ?? string.Empty,
            };

            return View(productDetails);
        }

        [HttpPost]
        public IActionResult EditWarehouseStock(WareHouseProduct newData)
        {
            if (newData != null)
            {
                WareHouseProduct? existing
                    = _unitOfWork?.WareHousesProducts?.GetWareHouseProduct(newData.ProductID, newData.WareHouseID);
                if (existing != null)
                {
                    existing.CurrentStock = newData.CurrentStock;
                    existing.MinStock = newData.MinStock;
                    existing.MaxStock = newData.MaxStock;

                    _unitOfWork?.Complete();

                    return RedirectToAction("ShowDetails", new { id = newData.ProductID });
                }
            }
            return BadRequest("Not Valid Data.");
        }
        #endregion

        #region Reporting
        public IActionResult OnGet()
        {
            //var product = _unitOfWork.Products.GetAll(new[] { "Supplier", "Category" }).ToList();
            var product = _ProductsAfterFilter.Select(p =>  
                new Product
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Supplier = _unitOfWork?.Suppliers?.GetbyIdAsync(p.SupplierID)?.Result ?? new Supplier(),
                    Category = _unitOfWork?.Categories?.GetbyIdAsync(p.CategoryID)?.Result ?? new Category(),
                    CategoryId = p.CategoryID,
                    SupplierId = p.SupplierID,
                }).DistinctBy(p => p.Id).ToList();

            _ProductsAfterFilter.Clear();

            var reportingService = new ReportingService();
            var document = reportingService.GetReport(product);


            MemoryStream stream = new MemoryStream();
            document.Save(stream);

            Response.ContentType = "application/pdf";
            Response.Headers.Add("content-length", stream.Length.ToString());
            byte[] bytes = stream.ToArray();
            stream.Close();
            var name = "Report" + DateTime.Now.ToString() + ".pdf";
            return File(bytes, "application/pdf", name);
        }
        #endregion
    }
}