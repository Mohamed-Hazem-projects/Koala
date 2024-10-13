using Inventory.Data.Models;
using Inventory.Data.ViewModels.Sales;
using System.Linq.Expressions;

namespace Inventory.Repository.Interfaces
{
    public interface ISalesRepository : IGenericRepository<Sales>
    {
        IEnumerable<SalesViewModel>? GetProdcutAndWareHouse(string[] includes = null);
        IEnumerable<SalesViewModel>? GetSalesPaginated(int pageNumber = 1);
        IEnumerable<SalesViewModel>? GetSalesPaginated(Expression<Func<Sales, bool>> match, int pageNumber = 1);
    }
}