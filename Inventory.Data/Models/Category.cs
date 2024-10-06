using KoalaInventoryManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Models
{
    public class Category : BaseEntity
    {
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
