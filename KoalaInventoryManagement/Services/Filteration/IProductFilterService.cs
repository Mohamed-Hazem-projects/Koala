using KoalaInventoryManagement.ViewModels.Products;

namespace KoalaInventoryManagement.Services.Filteration
{
    public interface IProductFilterService
    {
        List<ProductViewModel> ProductsPerRole(string userId, string userRole);
        List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string userRole);
    }
}
