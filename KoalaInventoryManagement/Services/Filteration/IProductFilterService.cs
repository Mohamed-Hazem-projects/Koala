using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.ViewModels.Products;

namespace KoalaInventoryManagement.Services.Filteration
{
    public interface IProductFilterService
    {
        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string role);
        public List<ProductViewModel> ProductsPerRole(int wareHouseId);
    }
}
