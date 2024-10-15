using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels;
using KoalaInventoryManagement.ViewModels.Dashboard;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Data.Models;

namespace KoalaInventoryManagement.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public DashboardController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);
            var dashboardViewModel = new DashboardViewModel();

            // Get total counts for all warehouses
            dashboardViewModel.WarehousesCount = _unitOfWork.DashBoard.GetWareHousesCount();
            dashboardViewModel.TotalProducts = _unitOfWork.DashBoard.GetProductsCount();
            dashboardViewModel.TotalStock = _unitOfWork.DashBoard.GetTotalStock();

            // Filter warehouses based on roles
            var warehouses = _unitOfWork.WareHouses.GetAll();
            if (roles.Any(role => role.StartsWith("WHManager")))
            {
                // Filter warehouses based on the specific WHManager role
                warehouses = warehouses.Where(wh => roles.Contains("WHManager" + wh.Id.ToString()));
            }

            dashboardViewModel.Warehouses = warehouses
                .Select(wh => new WarehouseViewModel
                {
                    Id = wh.Id,
                    Name = wh.Name,
                }).ToList();

            return View(dashboardViewModel);
        }

        public IActionResult GetWarehouseDetails()
        {
            WarehousesInfoViewModel warehouse = new WarehousesInfoViewModel();

            warehouse.ProductsPerWarehouse = _unitOfWork.DashBoard.GetTotalProductsPerWarehouse();
            List<string> warehousesNames = _unitOfWork.DashBoard.GetWarehousesNames();
            warehouse.WarehousesNames = warehousesNames;
            List<int> warehousesStocks = _unitOfWork.DashBoard.GetTotalStockPerWarehouse();

            // Handle empty warehouses
            if (warehousesStocks.Count < warehousesNames.Count)
            {
                int noOfEmptyWarehouses = warehousesNames.Count - warehousesStocks.Count;
                warehousesStocks.AddRange(new int[noOfEmptyWarehouses]);
            }
            // Create donut data
            for (int i = 0; i < warehousesNames.Count; i++)
            {
                warehouse.DonutData.Add(new donutData
                {
                    label = warehousesNames[i],
                    value = warehousesStocks[i]
                });
            }

            return Json(warehouse);
        }

        public IActionResult GetProductsInfoPerWarehouse(int Id)
        {
            ProductsInfoByWarehouseVM charts = new ProductsInfoByWarehouseVM();

            var productsPerCategory = _unitOfWork.DashBoard.GetProductsPerCategory(Id);
            charts.CategoriesNamesArray = productsPerCategory.Select(p => p.Category).ToArray();
            charts.productNumberArray = productsPerCategory.Select(p => p.ProductCount).ToArray();

            charts.productsPerSupplier = _unitOfWork.DashBoard.GetProductsPerSupplier(Id)
                .Select(x => new donutData
                {
                    label = x.Supplier,
                    value = x.ProductCount
                }).ToList();

            charts.categoryStockAverages = _unitOfWork.DashBoard.GetStocksAvgPerCategory(Id)
                .Select(x => new CategoryStockAverage
                {
                    Category = x.Category,
                    Min_Stock = x.Min_Stock,
                    Max_Stock = x.Max_Stock,
                    Current_Stock = x.Current_Stock,
                }).ToList();

            charts.lowStockNotifications = new LowStockNotificationsVM
            {
                WarehouseName = _unitOfWork?.DashBoard?.GetWarehouseName(Id),
                LowStockProductsCount = _unitOfWork.DashBoard.GetLowStockProductsCount(Id),
                LowStockProducts = _unitOfWork.DashBoard.GetLowStockProducts(Id)
                    .Select(x => new LowStockProducts
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Price = x.Price,
                        Max_Stock = x.Max_Stock,
                        Current_Stock = x.Current_Stock,
                        Min_Stock = x.Min_Stock,
                    }).ToList()
            };

            return Json(charts);
        }
    }
}
