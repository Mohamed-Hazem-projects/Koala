using KoalaInventoryManagement.ViewModels.Dashboard;

namespace KoalaInventoryManagement.ViewModels
{
    public class DashboardViewModel
    {
        public int WarehousesCount { get; set; }
        public int TotalProducts { get; set; }
        public int TotalStock { get; set; }
        public List<WarehouseViewModel> Warehouses { get; set; } 
    }
}
