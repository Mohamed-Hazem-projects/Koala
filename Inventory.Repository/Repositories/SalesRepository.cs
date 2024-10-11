using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Inventory.Data.ViewModels.Sales;
namespace Inventory.Repository.Repositories
{
    public class SalesRepository : GenericRepository<Sales>, ISalesRepository
    {
        public SalesRepository(InventoryDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SalesViewModel>? GetProdcutAndWareHouse()
        {
            return _context.Sales.Include(x => x.WareHouseProduct).ThenInclude(x => x.Product).ThenInclude(s => s.WareHouseProducts).ThenInclude(x => x.WareHouse).Select(s => new SalesViewModel
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
        }
    }
}