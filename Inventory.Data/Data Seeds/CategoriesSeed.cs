using Inventory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data_Seeds
{
    internal static class CategoriesSeed
    {
        public static List<Category> categories { get; set; } = new List<Category>
        {
            //change those according to the products you will put
            new Category{Id=1,Name="Electronics"},
            new Category{Id=2,Name="Clothing"},
            new Category{Id=3,Name="Groceries"},
            new Category{Id=4,Name="Furniture"},
            new Category{Id=5,Name="Accessories"},
        };
    }
}
