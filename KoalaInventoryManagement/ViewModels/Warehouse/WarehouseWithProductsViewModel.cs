using KoalaInventoryManagement.ViewModels.Products;
using KoalaInventoryManagement.ViewModels.Dashboard;
namespace KoalaInventoryManagement.ViewModels.Warehouse
{
    public class WarehouseWithProductsViewModel
    {
       public List<WarehouseViewModel> warehouse {  get; set; }
        public List<ProductViewModel> Products { get; set; } 
    }
}
