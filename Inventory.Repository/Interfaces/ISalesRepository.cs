using System.Linq.Expressions;
using Inventory.Data.Models;
using Inventory.Data.Shared;
using Inventory.Data.Shared.Sales;

namespace Inventory.Repository.Interfaces
{
    public interface ISalesRepository : IGenericRepository<Sales>
    {
        IEnumerable<SalesViewModel>? GetProdcutAndWareHouse(string[] includes = null);
        PaginatedList<SalesViewModel>? GetSalesPaginated(int pageNumber = 1);
        PaginatedList<SalesViewModel>? GetSalesPaginated(Expression<Func<Sales, bool>> match, int pageNumber = 1);
    }
}