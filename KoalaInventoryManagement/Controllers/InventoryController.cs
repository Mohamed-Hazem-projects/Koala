using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

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
            AllProductsViewModel? filterationViewModel = default;

            if (TempData["filterationViewModel"] != null)
            {
                var data = TempData["filterationViewModel"]?.ToString() ?? string.Empty;
                filterationViewModel = JsonConvert.DeserializeObject<AllProductsViewModel>(data);
            }

            if (filterationViewModel == null)
            {
                AllProductsViewModel ShowAllViewModle = new AllProductsViewModel()
                {
                    Products = _unitOfWork?.Products?.GetAll()?.ToList() ?? new List<Product>(),
                    WareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>(),

                    UnFilteredProducts = _unitOfWork?.WareHousesProducts?.GetAll()
                        .Select(p => new ProductViewModel()
                        {
                            Id = p.Product.Id,
                            Name = p.Product.Name,
                            Description = p.Product.Description,
                            Price = p.Product.Price,
                            Image = p?.Product.Image ?? [],
                            WareHouseName = p.WareHouse.Name,
                            CurrentStock = p.CurrentStock,
                            MintStock = p.MinStock,
                            MaxStock = p.MaxStock,
                        }).ToList() ?? new List<ProductViewModel>()
                };

                return View(ShowAllViewModle);
            }

            return View(filterationViewModel);
        }

        [HttpGet]
        public JsonResult GetFilteredProducts(string searchString, string showedProducts)
        {
            List<ProductViewModel>? filtered = JsonConvert.DeserializeObject<List<ProductViewModel>>(showedProducts);

            AllProductsViewModel allProductsViewModel = new AllProductsViewModel()
            {
                Products = _unitOfWork?.Products?.GetAll()?.ToList() ?? new List<Product>(),
                WareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>(),
                FilteredProducts = filtered ?? default,
            };

            if (!string.IsNullOrEmpty(searchString))
            {
                if(allProductsViewModel.FilteredProducts == null)
                {
                    allProductsViewModel.FilteredProducts = new List<ProductViewModel>();

                    List<Product> products
                        = _unitOfWork?.Products?.FindByName(p => p.Name.Contains(searchString))?.ToList()
                           ?? new List<Product>();

                    foreach (Product p in products)
                    {
                        List<WareHouseProduct> productWareHouse
                            = _unitOfWork?.WareHousesProducts?.GetProductWareHousesByPrdID(p.Id)?.ToList()
                                    ?? new List<WareHouseProduct>();

                        foreach (var i in productWareHouse)
                        {
                            allProductsViewModel.FilteredProducts.Add(
                            new ProductViewModel()
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Description = p.Description,
                                Price = p.Price,
                                Image = p?.Image ?? [],
                                WareHouseName = i.WareHouse.Name,
                                CurrentStock = i.CurrentStock,
                                MintStock = i.MinStock,
                                MaxStock = i.MaxStock,
                            }
                            );
                        }
                    }
                }
                else
                {
                    var result = allProductsViewModel.FilteredProducts.Where(p =>
                        p.Name.ToLower().Contains(searchString.ToLower())).ToList();

                    allProductsViewModel.FilteredProducts.Clear();
                    allProductsViewModel.FilteredProducts.AddRange(result);
                }
            }
            else
            {
                if (allProductsViewModel.FilteredProducts == null)
                {
                    allProductsViewModel = new AllProductsViewModel()
                    {
                        UnFilteredProducts = _unitOfWork?.WareHousesProducts?.GetAll()
                        .Select(p => new ProductViewModel()
                        {
                            Id = p.Product.Id,
                            Name = p.Product.Name,
                            Description = p.Product.Description,
                            Price = p.Product.Price,
                            Image = p?.Product.Image ?? [],
                            WareHouseName = p.WareHouse.Name,
                            CurrentStock = p.CurrentStock,
                            MintStock = p.MinStock,
                            MaxStock = p.MaxStock,
                        }).ToList() ?? new List<ProductViewModel>()
                    };
                }
            }

            return Json(allProductsViewModel);
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
            AllProductsViewModel filterationViewModel = new AllProductsViewModel()
            {
                Products = _unitOfWork?.Products?.GetAll()?.ToList() ?? new List<Product>(),
                WareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>(),

                UnFilteredProducts = _unitOfWork?.WareHousesProducts?.GetAll()
                        .Select(p => new ProductViewModel()
                        {
                            Id = p.Product.Id,
                            Name = p.Product.Name,
                            Description = p.Product.Description,
                            Price = p.Product.Price,
                            Image = p?.Product.Image ?? [],
                            WareHouseID = p.WareHouseID,
                            WareHouseName = p.WareHouse.Name,
                            CurrentStock = p.CurrentStock,
                            MintStock = p.MinStock,
                            MaxStock = p.MaxStock,
                        }).ToList() ?? new List<ProductViewModel>()
            };

            if (wareHouseID > 0)
            {
                filterationViewModel.SelectedWareHouse = wareHouseID;

                filterationViewModel.FilteredProducts
                    = filterationViewModel.UnFilteredProducts.Where(p => p.WareHouseID == wareHouseID).ToList();

                if (productID > 0 && filterationViewModel.FilteredProducts.Count > 0)
                {
                    filterationViewModel.SelectedProduct = productID;

                    ProductViewModel? p = filterationViewModel.FilteredProducts.FirstOrDefault(p => p.Id == productID);

                    if (p != null)
                    {
                        filterationViewModel.FilteredProducts.Clear();
                        filterationViewModel.FilteredProducts.Add(p);
                    }
                    else
                    {
                        filterationViewModel.FilteredProducts.Clear();
                    }
                }
            }
            else if (productID > 0)
            {
                filterationViewModel.SelectedProduct = productID;
                Product? p = filterationViewModel.Products.FirstOrDefault(p => p.Id == productID);

                if (p != null)
                {
                    filterationViewModel.FilteredProducts = new List<ProductViewModel>();
                    var theProductAtAllWareHouses = _unitOfWork.WareHousesProducts.GetAll()
                        .Where(whp => whp.ProductID == p.Id)
                        .Select(whp => new ProductViewModel
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Description = p.Description,
                            Price = p.Price,
                            Image = p?.Image ?? [],
                            WareHouseName = whp.WareHouse.Name,
                            CurrentStock = whp.CurrentStock,
                            MintStock = whp.MinStock,
                            MaxStock = whp.MaxStock
                        })
                        .ToList();

                    filterationViewModel.FilteredProducts.AddRange(theProductAtAllWareHouses);
                }
            }

            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All
            };
            TempData["filterationViewModel"] = JsonConvert.SerializeObject(filterationViewModel, settings);

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
        public IActionResult AddNewProduct()
        {
            var addNewProduct = _unitOfWork.Products.Add(new Models.Product { Name = "Test", Description = "Flags Test", Price = 20, CreateAt = DateTime.Now });
            _unitOfWork.Complete();
            return Ok(addNewProduct);
        }

        [HttpGet]
        public IActionResult DeleteProduct()
        {
            var DeleteProduct = _unitOfWork.Products.Delete(1);
            _unitOfWork.Complete();
            return Ok(_unitOfWork.Products.GetAll());
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
