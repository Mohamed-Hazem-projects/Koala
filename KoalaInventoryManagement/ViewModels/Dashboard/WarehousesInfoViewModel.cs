namespace KoalaInventoryManagement.ViewModels.Dashboard
{
    public class WarehousesInfoViewModel
    {
        public List<int> ProductsPerWarehouse { get; set; } = new List<int>();
        public List<donutData> DonutData { get; set; } = new List<donutData>();
        public List<String> WarehousesNames { get; set; } = new List<string>();
    }
}
