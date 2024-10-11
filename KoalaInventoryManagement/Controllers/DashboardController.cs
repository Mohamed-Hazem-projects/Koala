using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels;
using KoalaInventoryManagement.ViewModels.Dashboard;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            dashboardViewModel.WarehousesCount = _unitOfWork.DashBoard.GetWareHousesCount();
            dashboardViewModel.TotalProducts = _unitOfWork.DashBoard.GetProductsCount();
            dashboardViewModel.TotalStock = _unitOfWork.DashBoard.GetTotalStock();
            dashboardViewModel.Warehouses = _unitOfWork.WareHouses.GetAll()
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

            // Fetching data from the repository
            warehouse.ProductsPerWarehouse = _unitOfWork.DashBoard.GetTotalProductsPerWarehouse();
            List<string> warehousesNames = _unitOfWork.DashBoard.GetWarehousesNames();
            warehouse.WarehousesNames = warehousesNames;
            List<int> warehousesStocks = _unitOfWork.DashBoard.GetTotalStockPerWarehouse();

            // Special case: Empty warehouses
            if (warehousesStocks.Count < warehousesNames.Count)
            {
                int noOfEmptyWarehouses = warehousesNames.Count - warehousesStocks.Count;
                warehousesStocks.AddRange(new int[noOfEmptyWarehouses]);
            }
            // Iterate and create donut data if names and stocks are valid
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
            charts.CategoriesNamesArray = productsPerCategory.Select(productsPerCategory => productsPerCategory.Category).ToArray();
            charts.productNumberArray = productsPerCategory.Select(productsPerCategory => productsPerCategory.ProductCount).ToArray();

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

            charts.lowStockNotifications = new LowStockNotificationsVM();
            charts.lowStockNotifications.WarehouseName = _unitOfWork?.DashBoard?.GetWarehouseName(Id);
            charts.lowStockNotifications.LowStockProductsCount = _unitOfWork.DashBoard.GetLowStockProductsCount(Id);
            charts.lowStockNotifications.LowStockProducts = _unitOfWork
                                                                .DashBoard.GetLowStockProducts(Id)
                                                                .Select(x => new LowStockProducts
                                                                {
                                                                    ID = x.ID,
                                                                    Name = x.Name,
                                                                    Price = x.Price,
                                                                    Max_Stock = x.Max_Stock,
                                                                    Current_Stock = x.Current_Stock,
                                                                    Min_Stock = x.Min_Stock,
                                                                }).ToList();
            return Json(charts);
        }
    }
}
