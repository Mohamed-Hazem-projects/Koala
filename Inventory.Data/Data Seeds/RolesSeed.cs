using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Inventory.Data.Data_Seeds
{
    internal class RolesSeed
    {
        public static List<IdentityRole> Roles { get; set; } = new List<IdentityRole>
        {
            new IdentityRole{ Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole{ Name = "ManagerWH", NormalizedName = "MANAGERWH" },
            new IdentityRole{ Name = "Staff", NormalizedName = "STAFF" },
            new IdentityRole{ Name = "User", NormalizedName = "USER" } 
        };
    }
}
