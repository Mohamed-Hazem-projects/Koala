using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IProductsRepository : IGenericRepository<Product>
    {

        IEnumerable<Product>? GetProductsBySupplier(int supplierId);
        IEnumerable<Product>? GetProductsByCategory(int CategoryId);

    }
}
