using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize("Admin")]
    public class SalesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public IActionResult Index(int? pageNumber)
        {
            var sales = _unitOfWork.Sales.GetProdcutAndWareHouse()!
                .OrderByDescending(x => x.SaleDate)
                .ToList();
            var paginatedSales = _unitOfWork.Sales.GetSalesPaginated(pageNumber ?? 1)!;
            ViewBag.WareHouses = _unitOfWork.WareHousesProducts.GetAll(["Product", "WareHouse"])
            .Select(x => x.WareHouse)
            .DistinctBy(x => x.Name)
            .OrderBy(x => x.Name);
            return View(paginatedSales);
        }

        [HttpPost]
        public IActionResult GetProductSuggestions(string name, int warehouseId)
        {
            if (warehouseId == 0)
            {
                //var products = _unitOfWork.WareHousesProducts.FindByName(x => x.Product.Name.ToLower().Contains(name.ToLower()), [nameof(Product)]).Select(w => new
                //{
                //    w.Product.Id,
                //    w.Product.Name,
                //    w.Product.Price,
                //    w.CurrentStock,
                //});
                return Json(new List<object>());
            }
            var filteredProducts = _unitOfWork.WareHousesProducts.FindByName(x => x.WareHouseID == warehouseId, [nameof(Product)]).Where(x => x.Product.Name.ToLower().Contains(name.ToLower())).Select(x => new
            {
                x.Product.Id,
                x.Product.Name,
                x.Product.Price,
                x.CurrentStock,
                x.WareHouseID
            }).ToList();
            return Json(filteredProducts);
        }

        [HttpPost]
        public IActionResult AddSale(Sales? sale)
        {
            if (sale != null)
            {
                try
                {
                    var product = _unitOfWork.Products.GetbyId(sale.ProductId);
                    var warehouseProduct = _unitOfWork.WareHousesProducts.FindByName(w => w.ProductID == sale.ProductId && w.WareHouseID == sale.WareHouseId).SingleOrDefault();
                    if (warehouseProduct != null)
                    {
                        warehouseProduct.CurrentStock -= (short)sale.ItemsSold;
                        _unitOfWork.Sales.Add(sale);
                        _unitOfWork.Complete();
                    }
                    return Json(new { message = "success" });
                }
                catch (Exception ex)
                {
                    return Json(new { message = "error" });
                }
            }
            return Json(new { message = "failed" });
        }

        [HttpGet, HttpPost]
        public IActionResult GetUpdatedData(int pageNumber)
        {
            var sales = _unitOfWork.Sales.GetSalesPaginated(pageNumber)!;
            var list = new
            {
                sales = sales,
                TotalItems = sales.TotalItems,
                PageIndex = sales.PageIndex,
                PageNumbers = sales.PageNumbers,
                HasPreviousPage = sales.HasPreviousPage,
                HasNextPage = sales.HasNextPage,
                ItemCountPerPage = sales.ItemsCountPerPage
            };
            return Json(list);
        }


        public IActionResult DeleteSales(int salesId)
        {

            var result = _unitOfWork.Sales.Delete(salesId);
            if (!result)
            {
                return Json(new { message = "error" });
            }
            _unitOfWork.Complete();
            return Json(new { message = "success" });
        }

        public IActionResult FilterSales(int pageNumber, int warehouseId)
        {
            var sales = _unitOfWork.Sales.GetSalesPaginated(x => x.WareHouseProduct.WareHouseID == warehouseId, pageNumber)!;
            var response = new
            {
                sales = sales,
                TotalItems = sales.TotalItems,
                PageIndex = sales.PageIndex,
                PageNumbers = sales.PageNumbers,
                HasPreviousPage = sales.HasPreviousPage,
                HasNextPage = sales.HasNextPage,
                ItemCountPerPage = sales.ItemsCountPerPage
            };
            return Json(response);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}