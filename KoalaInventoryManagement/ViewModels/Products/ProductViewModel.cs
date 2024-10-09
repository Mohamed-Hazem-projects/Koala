using KoalaInventoryManagement.Models;

namespace KoalaInventoryManagement.ViewModels.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public byte[] Image { get; set; } = [];
        //public WareHouse ProductWareHouse { get; set; } = new WareHouse();
        public int WareHouseID { get; set; }
        public string WareHouseName { get; set; } = string.Empty;
        public int CurrentStock { get; set; }
        public int MintStock { get; set; }
        public int MaxStock { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int SupplierID { get; set; }
        public string SupplierName { get; set; } = string.Empty;
    }
}
