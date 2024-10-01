using Invetory.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Invetory.Data.Context
{
    public class InvetoryDbContext : IdentityDbContext<ApplicationUser>
    {

        public InvetoryDbContext(DbContextOptions<InvetoryDbContext> options):base(options)
        {
            
        }
    }
}
