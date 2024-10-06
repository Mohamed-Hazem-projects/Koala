using KoalaInventoryManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Models
{
    public class Supplier : BaseEntity
    {
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Phone_Number { get; set; }
        [MaxLength(50)]
        public string? Email_Address { get; set; }
        [Range(0,10)]
        public byte? Rating { get; set; }
        public string? Image { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
