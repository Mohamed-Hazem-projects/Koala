using Inventory.Data.Models;

namespace KoalaInventoryManagement.Models
{
    public class WareHouseProduct
    {
        public int WareHouseID { get; set; }
        public int ProductID { get; set; }
        public short MinStock { get; set; }
        public short CurrentStock { get; set; }
        public short MaxStock { get; set; }

        public virtual WareHouse WareHouse { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}
