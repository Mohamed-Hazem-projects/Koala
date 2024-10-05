using Inventory.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace KoalaInventoryManagement.Models
{
    public class WareHouse : BaseEntity
    {

        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        public virtual ICollection<WareHouseProduct> WareHouseProducts { get; set; } 
            = new HashSet<WareHouseProduct>();
    }
}
