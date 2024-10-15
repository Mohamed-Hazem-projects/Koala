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
                    _unitOfWork.Sales.Add(sale);
                    var product = _unitOfWork.WareHousesProducts.FindByName(w => w.ProductID == sale.ProductId && w.WareHouseID == sale.WareHouseId).SingleOrDefault();
                    if (product != null)
                    {
                        product.CurrentStock -= 1;
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
            return Json(sales);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}