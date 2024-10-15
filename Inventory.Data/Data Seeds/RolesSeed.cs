using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Inventory.Data.Data_Seeds
{
    internal class RolesSeed
    {
        public static List<IdentityRole> Roles { get; set; } = new List<IdentityRole>
        {
            new IdentityRole{ Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole{ Name = "Staff", NormalizedName = "STAFF" },
            new IdentityRole{ Name = "User", NormalizedName = "USER" },
            new IdentityRole{ Name = "WHManager1", NormalizedName = "WHMANAGER1" }, 
            new IdentityRole{ Name = "WHManager2", NormalizedName = "WHMANAGER2" }, 
            new IdentityRole{ Name = "WHManager3", NormalizedName = "WHMANAGER3" }, 
            new IdentityRole{ Name = "WHManager4", NormalizedName = "WHMANAGER4" }, 
            new IdentityRole{ Name = "WHManager5", NormalizedName = "WHMANAGER5" }      
        };
    }
}
