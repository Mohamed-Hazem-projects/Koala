using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
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

        public IGenericRepositoryAsync<Category> Categories { get; private set; }
        public IGenericRepositoryAsync<Supplier> Suppliers { get; private set; }
        public IGenericRepository<WareHouse> WareHouses { get; private set; }
        public IProductsRepository Products { get; private set; }
        public IWareHousesProductsRepository WareHousesProducts { get; private set; }
        public IDashBoardRepository DashBoard { get; private set; }
        public ISalesRepository Sales { get; private set; }
        public UnitOfWork(InventoryDbContext context)
        {
            _context = context;

            Categories = new GenericRepositoryAsync<Category>(_context);
            Suppliers = new GenericRepositoryAsync<Supplier>(_context);
            WareHouses = new GenericRepository<WareHouse>(_context);
            Products = new ProductsRepository(_context);
            WareHousesProducts = new WareHousesProductsRepository(_context);
            DashBoard = new DashBoardRepository(_context);
            Sales = new SalesRepository(_context);
        }

        public int Complete()
        {
            return _context?.SaveChanges() ?? -1;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
