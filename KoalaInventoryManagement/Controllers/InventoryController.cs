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

        public InventoryController(IUnitOfWork unitOfWork, IProductFilterService productFilter)
        {
            _unitOfWork = unitOfWork;
            _productFilter = productFilter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Get the role from session
            var userRole = HttpContext.Session.GetString("UserRole");

            // Extract the warehouse ID from the role (e.g., 'WHManager1' -> 1)
            int warehouseId = 0;
            if (userRole != null && userRole.StartsWith("WHManager"))
            {
                int.TryParse(userRole.Substring("WHManager".Length), out warehouseId);
            }

            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            List<Product> products;

            // Filter products based on warehouse role
            if (warehouseId > 0)
            {
                products = _unitOfWork?.Products?
                              .GetAll(new[] { "Supplier", "Category", "WareHouseProducts" })
                              ?.Where(p => p.WareHouseProducts.Any(whp => whp.WareHouseID == warehouseId))
                              ?.ToList() ?? new List<Product>();
            }
            else
            {
                // Default behavior (show all products if no warehouse-specific role)
                products = _unitOfWork?.Products?.GetAll(new[] { "Supplier", "Category", "WareHouseProducts" })?.ToList()
                            ?? new List<Product>();
            }

            // Convert products to view model
            List<WareHouse> wareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>();
            foreach (Product p in products)
            {
                foreach (WareHouseProduct whp in p.WareHouseProducts)
                {
                    productsViewModel.Add(new ProductViewModel()
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Price = p.Price,
                        Image = p.Image ?? new byte[0], // Use an empty byte array for image
                        WareHouseID = whp?.WareHouseID ?? 0,
                        WareHouseName = wareHouses?.Find(w => w.Id == whp?.WareHouseID)?.Name ?? string.Empty,
                        CurrentStock = whp?.CurrentStock ?? 0,
                        MintStock = whp?.MinStock ?? 0,
                        MaxStock = whp?.MaxStock ?? 0,
                        CategoryID = p?.CategoryId ?? 0,
                        CategoryName = p?.Category?.Name ?? string.Empty,
                        SupplierID = p?.SupplierId ?? 0,
                        SupplierName = p?.Supplier?.Name ?? string.Empty,
                    });
                }
            }

            return View(productsViewModel);
        }


        [HttpPost]
        public JsonResult GetFilteredProducts(int wareHouseID, int categoryID, int supplierID, string searchString, string showedProducts)
        {
            ViewBag.SelectedWareHouse = wareHouseID;
            ViewBag.SelectedCategory = categoryID;
            ViewBag.SelectedSupplier = supplierID;

            List<ProductViewModel> showedProductsNow = _productFilter?.FilterData(wareHouseID, 
                categoryID, supplierID, searchString, showedProducts) ?? new List<ProductViewModel>();

            return Json(showedProductsNow);
        }

        [HttpPost]
        public IActionResult AddProduct(Product newProduct, WareHouseProduct wareHouseProduct, IFormFile file)
        {
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

            if (newProduct == null)
            {
                return BadRequest("Product information is required.");
            }

            // Add the product using UnitOfWork pattern
            if (_unitOfWork?.Products?.Add(newProduct) ?? false)
            {
                _unitOfWork?.Complete();
                wareHouseProduct.ProductID = newProduct.Id;

                // Add the warehouse product relationship
                if (_unitOfWork?.WareHousesProducts?.Add(wareHouseProduct) ?? false)
                {
                    _unitOfWork?.Complete();
                }

                return RedirectToAction("Index");
            }

            return StatusCode(500, "Failed to add the product.");
        }

        [HttpGet]
		public IActionResult DeleteProduct(int id)
		{
			if (_unitOfWork?.Products?.Delete(id) ?? false)
			{
				_unitOfWork?.Complete();
				return RedirectToAction("Index");
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
                    }
                    else
                    {
                        return BadRequest("Only image files (.jpg, .jpeg, .png, .gif) are allowed.");
                    }
                }

                // Update the existing product
                _unitOfWork?.Products?.Update(existingProduct);
                _unitOfWork?.Complete();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ShowDetails(int id)
        {
            Product? product
                = _unitOfWork?.Products?.GetbyId(id, ["Supplier", "Category"]) ?? new Product();

            List<WareHouseProduct> prdWareHouses
                = _unitOfWork?.WareHousesProducts?
                              .GettWareHousesProductsByPrdID(id, ["WareHouse"])?
                              .ToList() ?? new List<WareHouseProduct>();


            int productQuantity = 0;
            foreach(int currentStock in prdWareHouses.Select(whp => whp.CurrentStock))
                productQuantity += currentStock;

            ProductDetailsVM productDetails = new ProductDetailsVM()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image ?? [0],
                Quantity = productQuantity,
                ProductWareHouses = prdWareHouses,
                CategoryName = product?.Category?.Name ?? string.Empty,
                SupplierName = product?.Supplier?.Name ?? string.Empty,
            };

            return View(productDetails);
        }

        public IActionResult OnGet()
        {
            var product = _unitOfWork.Products.GetAll(new[] { "Supplier", "Category" }).ToList();
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




    }

    }
