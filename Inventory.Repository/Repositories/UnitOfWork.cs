using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InventoryDbContext _context;
        public IGenericRepositoryAsync<Category> Categories{ get; private set; }

        public IGenericRepository<Supplier> Suppliers { get; private set; }

        public UnitOfWork(InventoryDbContext context)
        {
            _context=context;
            Categories = new GenericRepositoryAsync<Category>(_context);
            Suppliers = new GenericRepository<Supplier>(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
