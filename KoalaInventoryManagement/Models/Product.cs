using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoalaInventoryManagement.Models
{
    public class Product
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public double Price { get; set; }
        public byte[]? Image { get; set; }

        public virtual ICollection<WareHouseProduct> WareHouseProducts { get; set; }
            = new List<WareHouseProduct>();
    }
}
