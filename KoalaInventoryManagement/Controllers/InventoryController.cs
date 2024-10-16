using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.Services.Filteration;
using KoalaInventoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize]
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductFilterService _productFilter;
        List<ProductViewModel> _filteredProducts;

        public InventoryController(IUnitOfWork unitOfWork, IProductFilterService productFilter)
        {
            _unitOfWork = unitOfWork;
            _productFilter = productFilter;
            _filteredProducts = new List<ProductViewModel>();
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 10)
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

            var paginatedProducts = productsViewModel.Skip((page - 1) * pageSize).Take(pageSize).DistinctBy(p => p.Id).ToList();

            // Pass pagination metadata to the view
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling(productsViewModel.Count / (double)pageSize);

            return View(paginatedProducts);
        }


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

            var paginatedProducts = filteredProducts.Skip((page - 1) * pageSize).Take(pageSize).DistinctBy(p => p.Id).ToList();

            return Json(new
            {
                products = paginatedProducts,
                currentPage = page,
                totalPages = (int)Math.Ceiling(filteredProducts.Count / (double)pageSize)
            });
        }

        [HttpPost]
        public IActionResult AddProduct(Product newProduct, WareHouseProduct wareHouseProduct)
        {
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

            return StatusCode(500, "Failed to add the product."); // Or handle more gracefully
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
        public IActionResult UpdateProduct(Product editedProduct)
        {
            if (editedProduct == null)
            {
                return BadRequest("Product information is required.");
            }
            if (editedProduct != null)
            {
                Product? existingProduct = _unitOfWork?.Products?.GetbyId(editedProduct.Id);
                if (existingProduct != null)
                {
                    if (_unitOfWork?.Products?.Update(editedProduct) ?? false)
                        _unitOfWork?.Complete();
                }
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
            foreach (int currentStock in prdWareHouses.Select(whp => whp.CurrentStock))
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
    }
}
