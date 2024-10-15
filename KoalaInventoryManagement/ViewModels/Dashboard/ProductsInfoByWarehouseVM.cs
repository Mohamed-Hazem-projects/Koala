namespace KoalaInventoryManagement.ViewModels.Dashboard
{
    public class ProductsInfoByWarehouseVM
    {
        public string[] CategoriesNamesArray { get; set; }
        public int[] productNumberArray { get; set; }
        public List<donutData> productsPerSupplier { get; set; }
        public List<CategoryStockAverage> categoryStockAverages { get; set; }
        public LowStockNotificationsVM lowStockNotifications { get; set; }
    }
}
