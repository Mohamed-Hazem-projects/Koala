using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Inventory.Data.Data_Seeds
{
    internal class RolesSeed
    {
        public static List<IdentityRole> Roles { get; set; } = new List<IdentityRole>
        {
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "Staff", NormalizedName = "STAFF" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "WHManager1", NormalizedName = "WHMANAGER1" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "WHManager2", NormalizedName = "WHMANAGER2" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "WHManager3", NormalizedName = "WHMANAGER3" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "WHManager4", NormalizedName = "WHMANAGER4" },
            new IdentityRole{ Id = Guid.NewGuid().ToString(), Name = "WHManager5", NormalizedName = "WHMANAGER5" }
        };
    }
}
