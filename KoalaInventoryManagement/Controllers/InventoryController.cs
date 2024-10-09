using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using NuGet.Configuration;

namespace KoalaInventoryManagement.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public InventoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            List<Product> products
                = _unitOfWork?.Products?.GetAll(["Supplier", "Category", "WareHouseProducts"])?.ToList()
                    ?? new List<Product>();
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
                        Image = p.Image ?? [0],
                        WareHouseID = whp.WareHouseID,
                        WareHouseName = wareHouses?.Find(w => w.Id == whp.WareHouseID)?.Name ?? string.Empty,
                        CurrentStock = whp.CurrentStock,
                        MintStock = whp.MinStock,
                        MaxStock = whp.MaxStock,
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
        public JsonResult GetFilteredProducts(int wareHouseID, string searchString, string showedProducts)
        {
            List<ProductViewModel>? showedProductsNow = JsonConvert.DeserializeObject<List<ProductViewModel>>(showedProducts);

            if (showedProductsNow == null)
                showedProductsNow = new List<ProductViewModel>();

            ViewBag.SelectedWareHouse = wareHouseID;
            ViewBag.SelectedProduct = 0;

            if (wareHouseID > 0)
            {
                WareHouse wareHouse = _unitOfWork?.WareHouses?.GetbyId(wareHouseID) ?? new WareHouse();

                if (!string.IsNullOrEmpty(searchString))
                {
                    List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                        .Where(s => s.Name.Contains(searchString)).ToList();

                    return Json(result);
                }
                else
                {
                    List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id).ToList();
                    return Json(result);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    List<ProductViewModel> result = showedProductsNow.Where(s => s.Name.Contains(searchString)).ToList();
                    return Json(result);
                    #region Old Work
                    //    showedProductsNow.Clear();

                    //    List<Product> products
                    //        = _unitOfWork?.Products?.FindByName(p => p.Name.Contains(searchString),
                    //            ["Supplier", "Category", "WareHouseProducts"])?.ToList()
                    //                ?? new List<Product>();

                    //    foreach (Product p in products)
                    //    {
                    //        foreach (WareHouseProduct whp in p.WareHouseProducts)
                    //        {
                    //            showedProductsNow.Add(new ProductViewModel()
                    //            {
                    //                Id = p.Id,
                    //                Name = p.Name,
                    //                Description = p.Description,
                    //                Price = p.Price,
                    //                Image = p.Image ?? [0],
                    //                WareHouseID = whp.WareHouseID,
                    //                WareHouseName = wareHouses?.Find(w => w.Id == whp.WareHouseID)?.Name ?? string.Empty,
                    //                CurrentStock = whp.CurrentStock,
                    //                MintStock = whp.MinStock,
                    //                MaxStock = whp.MaxStock,
                    //                CategoryID = p?.CategoryId ?? 0,
                    //                CategoryName = p?.Category?.Name ?? string.Empty,
                    //                SupplierID = p?.SupplierId ?? 0,
                    //                SupplierName = p?.Supplier?.Name ?? string.Empty,
                    //            });
                    //        }
                    //    }
                    //    //return Json(showedProductsNow);
                    //} 
                    #endregion
                }
            }

            return Json(showedProductsNow);
        }

        [HttpPost]
        public IActionResult GetByFilter(int productID, int wareHouseID)
        {
            if (productID > 0 || wareHouseID > 0)
                return RedirectToAction("ApplyFilter", new { wareHouseID, productID });
            else
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ApplyFilter(int wareHouseID, int productID)
        {

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search()
        {
            var searchTerm = "Palestine Flag".ToLower(); // Convert the search term to lowercase
            var ProductName = _unitOfWork.Products.FindByName(
                a => a.Name.ToLower().Contains(searchTerm)
            );
            return Ok(ProductName);
        }

        [HttpPost]
        public IActionResult AddProduct(Product newProduct, WareHouseProduct wareHouseProduct)
        {
            // Add the new product to the database
            _unitOfWork.Products.Add(newProduct);
            _unitOfWork.Complete();
            wareHouseProduct.ProductID = _unitOfWork?.Products?.GetAll()?.LastOrDefault()?.Id ?? 0;
            _unitOfWork.WareHousesProducts.Add(wareHouseProduct);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {

            _unitOfWork.Products.Delete(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct()
        {
            var UpdateProduct = _unitOfWork.Products.Update(new Models.Product { Id = 5, Name = "salama2", Description = "Test salama2", Price = 50 });
            _unitOfWork.Complete();
            return Ok(UpdateProduct);
        }

        [HttpGet]
        public IActionResult GetAllProductSupplier()
        {
            var products = _unitOfWork.Products.GetProductsBySupplier(1);
            return Ok(products);
        }

        [HttpGet]
        public IActionResult GetAllProductCategory()
        {
            var products = _unitOfWork.Products.GetProductsByCategory(1);
            return Ok(products);
        }
    }
}
