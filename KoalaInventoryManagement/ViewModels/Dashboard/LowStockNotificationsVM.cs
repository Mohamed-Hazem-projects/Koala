namespace KoalaInventoryManagement.ViewModels.Dashboard
{
    public class LowStockNotificationsVM
    {
        public string WarehouseName { get; set; }
        public int LowStockProductsCount { get; set; }
        public List<LowStockProducts> LowStockProducts { get;set; }
    }
    public class LowStockProducts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Min_Stock { get; set; }
        public int Current_Stock { get; set; }
        public int Max_Stock { get; set; }
    }
}
