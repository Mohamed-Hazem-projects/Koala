using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Inventory.Data.Data_Seeds
{
    internal class RolesSeed
    {
        public static List<IdentityRole> Roles { get; set; } = new List<IdentityRole>
        {
            new IdentityRole{ Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole{ Id = "2", Name = "ManagerWH", NormalizedName = "MANAGERWH" },
            new IdentityRole{ Id = "3", Name = "Staff", NormalizedName = "STAFF" },
            new IdentityRole{ Id = "4", Name = "User", NormalizedName = "USER" } 
        };
    }
}
