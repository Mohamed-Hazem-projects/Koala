using System.Linq.Expressions;
using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Data.Shared;
using Inventory.Data.Shared.Sales;
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

        public PaginatedList<SalesViewModel>? GetSalesPaginated(int pageNumber)
        {
            var query = _context.Sales.OrderByDescending(x => x.SaleDate).Select(s => new SalesViewModel
            {
                Id = s.Id,
                ProductName = s.WareHouseProduct.Product.Name,
                ProductId = s.WareHouseProduct.ProductID,
                WareHouseName = s.WareHouseProduct.WareHouse.Name,
                WareHouseId = s.WareHouseProduct.WareHouseID,
                SaleDate = s.SaleDate,
                TotalPrice = s.TotalPrice,
                ItemsSold = s.ItemsSold
            });
            return PaginatedList<SalesViewModel>.GetPaginatedList(query, pageNumber);
        }

        public IEnumerable<SalesViewModel>? GetProdcutAndWareHouse(string[]? includes = null)
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

        public PaginatedList<SalesViewModel>? GetSalesPaginated(Expression<Func<Sales, bool>> match, int pageNumber = 1)
        {
            IQueryable<Sales> query = _context.Sales;
            if (match != null)
            {
                query = query.Include(s => s.WareHouseProduct).ThenInclude(w => w.Product).ThenInclude(p => p.WareHouseProducts).ThenInclude(w => w.WareHouse);
                query = query.Where(match);
            }
            var newQuery = query.OrderByDescending(s => s.SaleDate).Select(s => new SalesViewModel
            {
                Id = s.Id,
                ProductName = s.WareHouseProduct.Product.Name,
                ProductId = s.WareHouseProduct.ProductID,
                WareHouseName = s.WareHouseProduct.WareHouse.Name,
                WareHouseId = s.WareHouseProduct.WareHouseID,
                SaleDate = s.SaleDate,
                TotalPrice = s.TotalPrice,
                ItemsSold = s.ItemsSold
            });

            return PaginatedList<SalesViewModel>.GetPaginatedList(newQuery, pageNumber);
        }
    }
}