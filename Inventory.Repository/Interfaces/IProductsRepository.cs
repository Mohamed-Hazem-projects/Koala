using KoalaInventoryManagement.Models;


namespace Inventory.Repository.Interfaces
{
    public interface IProductsRepository : IGenericRepository<Product>
    {

        IEnumerable<Product>? GetProductsBySupplier(int supplierId);
        IEnumerable<Product>? GetProductsByCategory(int CategoryId);

    }
}
