using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data_Seeds
{
    public static class ProductsSeed
    {
        public static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product()
            {
                Id = 1, Name = "Palestine Flag", Description = "Flags Products", Price = 9
            },
            new Product()
            {
                Id = 2, Name = "Gun AK-74", Description = "Guns Products", Price = 1000
            },
            new Product()
            {
                Id = 3, Name = "زبادي", Description = "Food Products", Price = 3
            },
        };
    }
}
