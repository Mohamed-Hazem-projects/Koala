using Inventory.Data.Models;
using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepositoryAsync<Category> Categories { get; }
        IGenericRepository<Supplier> Suppliers { get; }
        IGenericRepository<WareHouse> WareHouses { get; }
        IProductsRepository Products { get; }
        IWareHousesProductsRepository WareHousesProducts { get; }

        int Complete();

        Task<int> CompleteAsync();
    }
}
