using KoalaInventoryManagement.ViewModels.Products;

namespace KoalaInventoryManagement.Services.Filteration
{
    public interface IProductFilterService
    {
        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string role);
    }
}
