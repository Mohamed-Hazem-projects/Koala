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
        public IGenericRepository<Category> Categories{ get; private set; }

        public IGenericRepository<Supplier> Suppliers { get; private set; }

        public UnitOfWork(InventoryDbContext context)
        {
            _context=context;
            Categories = new GenericRepository<Category>(_context);
            Suppliers = new GenericRepository<Supplier>(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
