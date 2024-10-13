using KoalaInventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Models
{
    public class Sales : BaseEntity
    {
        public int ItemsSold { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }

        public virtual WareHouseProduct WareHouseProduct { get; set; }
        public int ProductId { get; set; }
        public int WareHouseId { get; set; }
    }
}