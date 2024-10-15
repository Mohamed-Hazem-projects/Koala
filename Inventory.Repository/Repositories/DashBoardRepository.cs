using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;

namespace Inventory.Repository.Repositories
{
    public class DashBoardRepository : IDashBoardRepository
    {
        private readonly InventoryDbContext _context;
        public DashBoardRepository(InventoryDbContext context)
        {
            _context = context;
        }
        public int GetWareHousesCount()
        {
            return _context.WareHouses.Count();
        }
        public int GetProductsCount()
        {
            return _context.Products.Count();
        }
        public int GetTotalStock()
        {
            return _context.WareHousesProducts.Sum((wp) => wp.CurrentStock);
        }
        public List<string> GetWarehousesNames()
        {
            return _context.WareHouses.Select(wh => wh.Name).ToList();
        }
        public List<int> GetTotalProductsPerWarehouse()
        {
            return _context.WareHousesProducts
                           .GroupBy(wh => wh.WareHouseID)
                           .Select(whgroup => whgroup.Count())
                           .ToList();
        }
        public List<int> GetTotalStockPerWarehouse()
        {
            return _context.WareHousesProducts
                           .GroupBy(wh => wh.WareHouseID)
                           .Select(whgroup => whgroup.Sum(wh => wh.CurrentStock))
                           .ToList();
        }
        public List<CategoryProductCount> GetProductsPerCategory(int warehouseID)
        {
            return _context.Products
                            .Join(_context.Categories,
                                product => product.CategoryId,
                                category => category.Id,
                                (product, category) => new
                                {
                                    Category = category.Name,
                                    ProductID = product.Id
                                })
                            .Join(_context.WareHousesProducts,
                                product => product.ProductID,
                                warehouse => warehouse.ProductID,
                                (product, warehouse) => new
                                {
                                    product.Category,
                                    product.ProductID,
                                    warehouseId = warehouse.WareHouseID
                                })
                            .Where(table => table.warehouseId == warehouseID)
                            .GroupBy(table => table.Category)
                            .Select(group => new CategoryProductCount
                            {
                                Category = group.Key,
                                ProductCount = group.ToList().Count()
                            }).ToList();

        }
        public List<SupplierProductCount> GetProductsPerSupplier(int warehouseID)
        {
            return _context.Products
                            .Join(_context.Suppliers,
                                product => product.SupplierId,
                                supplier => supplier.Id,
                                (product, supplier) => new
                                {
                                    Supplier = supplier.Name,
                                    ProductID = product.Id
                                })
                            .Join(_context.WareHousesProducts,
                                product => product.ProductID,
                                warehouse => warehouse.ProductID,
                                (product, warehouse) => new
                                {
                                    product.Supplier,
                                    product.ProductID,
                                    warehouseId = warehouse.WareHouseID
                                })
                            .Where(table => table.warehouseId == warehouseID)
                            .GroupBy(table => table.Supplier)
                            .Select(group => new SupplierProductCount
                            {
                                Supplier = group.Key,
                                ProductCount = group.ToList().Count()
                            }).ToList();

        }
        public List<CategoryStockAverage> GetStocksAvgPerCategory(int warehouseID)
        {
            return _context.Products
                            .Join(_context.Categories,
                                product => product.CategoryId,
                                category => category.Id,
                                (product, category) => new
                                {
                                    Category = category.Name,
                                    ProductID = product.Id
                                })
                            .Join(_context.WareHousesProducts,
                                product => product.ProductID,
                                warehouse => warehouse.ProductID,
                                (product, warehouse) => new
                                {
                                    product.Category,
                                    min_stock = warehouse.MinStock,
                                    current_stock = warehouse.CurrentStock,
                                    max_stock = warehouse.MaxStock,
                                    warehouseId = warehouse.WareHouseID
                                })
                            .Where(table => table.warehouseId == warehouseID)
                            .GroupBy(table => table.Category)
                            .Select(group => new CategoryStockAverage
                            {
                                Category = group.Key,
                                Min_Stock = (int)group.ToList().Average(catStock => catStock.min_stock),
                                Current_Stock = (int)group.ToList().Average(catStock => catStock.current_stock),
                                Max_Stock = (int)group.ToList().Average(catStock => catStock.max_stock)
                            }).ToList();

        }
        public string GetWarehouseName(int warehouseID)
        {
            return _context.WareHouses?.Find(warehouseID)?.Name ?? "";
        }
        public int GetLowStockProductsCount(int warehouseID)
        {
            return _context.WareHousesProducts
                           .Where(wh => wh.WareHouseID == warehouseID)
                           .Where(wh => wh.CurrentStock <= wh.MinStock)
                           .Count();
        }
        public List<LowStockProduct> GetLowStockProducts(int warehouseID)
        {
            return _context.Products
                            .Join(_context.WareHousesProducts,
                                product => product.Id,
                                warehouse => warehouse.ProductID,
                                (product, warehouse) => new
                                {
                                    product.Id,
                                    product.Name,
                                    product.Price,
                                    min_stock = warehouse.MinStock,
                                    current_stock = warehouse.CurrentStock,
                                    max_stock = warehouse.MaxStock,
                                    warehouseId = warehouse.WareHouseID
                                })
                            .Where(product => product.warehouseId == warehouseID)
                            .Where(product => product.current_stock < product.min_stock)
                            .Select(product => new LowStockProduct
                            {
                                ID=product.Id,
                                Name=product.Name,
                                Price=product.Price,
                                Min_Stock=product.min_stock,
                                Current_Stock=product.current_stock,
                                Max_Stock=product.max_stock
                            }).ToList();
        }
    }
    public class CategoryProductCount
    {
        public string Category { get; set; }
        public int ProductCount { get; set; }
    }
    public class SupplierProductCount
    {
        public string Supplier { get; set; }
        public int ProductCount { get; set; }
    }
    public class StockInfo
    {
        public int Min_Stock { get; set; }
        public int Current_Stock { get; set; }
        public int Max_Stock { get; set; }
    }
    public class CategoryStockAverage : StockInfo
    {
        public string Category { get; set; }
    }
    public class LowStockProduct : StockInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

