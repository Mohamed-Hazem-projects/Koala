using Inventory.Data.Models;
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
        int Complete();
        Task<int> CompleteAsync();
    }
}
