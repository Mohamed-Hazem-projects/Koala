using Inventory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data_Seeds
{
    internal static class SuppliersSeed
    {
        public static List<Supplier> suppliers { get; set; } = new List<Supplier>
        {
            //change those according to the products you will put
            new Supplier{Id=1,Name="Misr Pyramids Group", Phone_Number="01523456789",Email_Address="pyramidsmail@pyr.com",Rating=7},
            new Supplier{Id=2,Name="Hero Basics", Phone_Number="01283492232",Email_Address="hero@basics.com",Rating=5},
            new Supplier{Id=3,Name="Resi Trade", Phone_Number="01129555939",Email_Address="Resi@trade.com",Rating=9},
            new Supplier{Id=4,Name="lamar", Phone_Number="01522233333",Email_Address="Lamar@gmail.com",Rating=3},
            new Supplier{Id=5,Name="Hazlam", Phone_Number="01575732113",Email_Address="info@Hazlam.com",Rating=8}
        };
    }
}
