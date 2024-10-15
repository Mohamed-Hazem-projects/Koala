using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.Services.Filteration;
using KoalaInventoryManagement.ViewModels.Products;
using Newtonsoft.Json;

namespace KoalaInventoryManagement.Services
{
    public class ProductsFilterService : IProductFilterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsFilterService(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string showedProducts)
        {
            List<ProductViewModel>? showedProductsNow = JsonConvert.DeserializeObject<List<ProductViewModel>>(showedProducts);

            if (showedProductsNow == null)
                showedProductsNow = new List<ProductViewModel>();


            var filteredProducts = showedProductsNow.AsQueryable();

            if (wareHouseID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.WareHouseID == wareHouseID);
            }
            if (categoryID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.CategoryID == categoryID);
            }
            if (supplierID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.SupplierID == supplierID);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                filteredProducts = filteredProducts.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
            }

            return filteredProducts.ToList();
        }
    }
}
