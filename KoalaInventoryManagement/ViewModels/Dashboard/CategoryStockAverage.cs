namespace KoalaInventoryManagement.ViewModels.Dashboard
{
    public class CategoryStockAverage
    {
        public string Category { get; set; }
        public int Min_Stock { get; set; }
        public int Current_Stock { get; set; }
        public int Max_Stock { get; set; }
    }
}
