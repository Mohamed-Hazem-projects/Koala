using Inventory.Data.Models;
using Inventory.Data.ViewModels.Sales;


namespace Inventory.Repository.Interfaces
{
    public interface ISalesRepository : IGenericRepository<Sales>
    {
        IEnumerable<SalesViewModel>? GetProdcutAndWareHouse();
    }
}