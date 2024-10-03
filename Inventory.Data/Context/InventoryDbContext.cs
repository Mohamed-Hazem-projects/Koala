using Inventory.Data.Data_Seeds;
using Inventory.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.Context
{
    public class InventoryDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(CategoriesSeed.categories);
            builder.Entity<Supplier>().HasData(SuppliersSeed.suppliers);

            base.OnModelCreating(builder);
        }
    }
}
