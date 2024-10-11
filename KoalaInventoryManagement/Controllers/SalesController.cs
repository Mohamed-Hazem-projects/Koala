using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Inventory.Data.ViewModels;

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
                var products = _unitOfWork.Products.FindByName(x => x.Name.ToLower().Contains(name.ToLower()))
                          .Select(x => new { x.Id, x.Name, x.Price })
                          .DistinctBy(x => x.Name)
                          .ToList();

                return Json(products);
            }
            var filteredProducts = _unitOfWork.WareHousesProducts.FindByName(x => x.WareHouseID == warehouseId, ["Product"]).Where(x => x.Product.Name.ToLower().Contains(name.ToLower())).ToList();
            return Json(filteredProducts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}