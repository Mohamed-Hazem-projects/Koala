using Inventory.Repository.Repositories;

namespace Inventory.Repository.Interfaces
{
    public interface IDashBoardRepository
    {
        public int GetWareHousesCount();
        public int GetProductsCount();
        public int GetTotalStock();
        public List<string> GetWarehousesNames();
        public List<int> GetTotalProductsPerWarehouse();
        public List<int> GetTotalStockPerWarehouse();
        public List<CategoryProductCount> GetProductsPerCategory(int warehouseID);
        public List<SupplierProductCount> GetProductsPerSupplier(int warehouseID);
        public List<CategoryStockAverage> GetStocksAvgPerCategory(int warehouseID);
        public string GetWarehouseName(int warehouseID);
        public int GetLowStockProductsCount(int warehouseID);
        public List<LowStockProduct> GetLowStockProducts(int warehouseID);
    }
}
