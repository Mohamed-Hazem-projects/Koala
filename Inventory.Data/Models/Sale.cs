using KoalaInventoryManagement.Models;

namespace Inventory.Data.Models
{
    public class Sales : BaseEntity
    {
        public int ItemsBought { get; set; }
        public DateTime SaleTime { get; set; }
        public decimal TotalProfit { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}