using KoalaInventoryManagement.Models;

namespace KoalaInventoryManagement.ViewModels.Products
{
    public class ProductDetailsVM
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public byte[] Image { get; set; } = [];
        public int Quantity { get; set; }
        public List<WareHouseProduct> ProductWareHouses { get; set; } = new List<WareHouseProduct>();
        public string CategoryName { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
    }
}
