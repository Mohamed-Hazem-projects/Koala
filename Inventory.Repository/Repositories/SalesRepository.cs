using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Data.ViewModels.Sales;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Inventory.Repository.Repositories
{
    public class SalesRepository : GenericRepository<Sales>, ISalesRepository
    {
        public SalesRepository(InventoryDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SalesViewModel>? GetProdcutAndWareHouse(string[] includes = null)
        {
            //return _context.Sales.Include(x => x.WareHouseProduct).ThenInclude(x => x.Product).ThenInclude(s => s.WareHouseProducts).ThenInclude(x => x.WareHouse).Select(s => new SalesViewModel
            //{
            //    Id = s.Id,
            //    ProductName = s.WareHouseProduct.Product.Name,
            //    ProductId = s.WareHouseProduct.ProductID,
            //    WareHouseName = s.WareHouseProduct.WareHouse.Name,
            //    WareHouseId = s.WareHouseProduct.WareHouseID,
            //    SaleDate = s.SaleDate,
            //    TotalPrice = s.TotalPrice,
            //    ItemsSold = s.ItemsSold
            //}).ToList();
            IQueryable<Sales> query = _context.Sales;

            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            var model = query.Select(s => new SalesViewModel
            {
                Id = s.Id,
                ProductName = s.WareHouseProduct.Product.Name,
                ProductId = s.WareHouseProduct.ProductID,
                WareHouseName = s.WareHouseProduct.WareHouse.Name,
                WareHouseId = s.WareHouseProduct.WareHouseID,
                SaleDate = s.SaleDate,
                TotalPrice = s.TotalPrice,
                ItemsSold = s.ItemsSold
            }).ToList();

            return model;
        }
    }
}