using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class SalesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var sales = _unitOfWork.Sales.GetProdcutAndWareHouse()!;
            var warehouseProductJunction = _unitOfWork.WareHousesProducts.GetAll(["Product", "WareHouse"]);
            ViewBag.WareHouses = warehouseProductJunction.Select(x => x.WareHouse).DistinctBy(x => x.Name).OrderBy(x => x.Name);
            return View(sales);
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
                _unitOfWork.Sales.Add(sale);
                _unitOfWork.Complete();
                var product = _unitOfWork.WareHousesProducts.FindByName(w => w.ProductID == sale.ProductId && w.WareHouseID == sale.WareHouseId).SingleOrDefault();
                if (product != null)
                {
                    product.CurrentStock -= 1;
                    _unitOfWork.Complete();
                }
                return Json(new { message = "success" });
            }
            return Json(new { message = "failed" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}