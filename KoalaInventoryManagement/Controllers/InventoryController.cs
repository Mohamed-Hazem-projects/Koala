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

            var paginatedProducts 
                = productsViewModel.Skip((page - 1) * pageSize).Take(pageSize).DistinctBy(p => p.Id).ToList();

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

                if(warehouseId > 0)
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