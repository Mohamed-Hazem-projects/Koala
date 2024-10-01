using Microsoft.EntityFrameworkCore;

namespace KoalaInventoryManagement.Models.Context
{
    public class InventoryDBContext : DbContext
    {
        #region Inventory Tables DbSets
        public virtual DbSet<WareHouse> WareHouses { get; set; }
        public virtual DbSet<WareHouseProduct> WareHouseProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; } 
        #endregion

        public InventoryDBContext() : base()
        { }

        public InventoryDBContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region WareHouse and Product M:M Relation
            //composite primary key
            modelBuilder.Entity<WareHouseProduct>()
                        .HasKey(whp => new { whp.ProductID, whp.WareHouseID });

            modelBuilder.Entity<WareHouse>()
                            .HasMany(w => w.WareHouseProducts)
                            .WithOne(whp => whp.WareHouse)
                            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                        .HasMany(p => p.WareHouseProducts)
                        .WithOne(whp => whp.Product)
                        .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Data Seeding
            List<WareHouse> wareHouses = new List<WareHouse>()
            {
                new WareHouse() {ID = 1, Name = "Section A"},
                new WareHouse() {ID = 2, Name = "Section B"},
                new WareHouse() {ID = 3, Name = "Section C"},
            };
            modelBuilder.Entity<WareHouse>()
                        .HasData(wareHouses);

            List<Product> products = new List<Product>()
            {
                new Product() 
                {
                    ID = 1, Name = "Palestine Flag", Description = "Flags Products", Price = 9
                },
                new Product() 
                {
                    ID = 2, Name = "Gun AK-74", Description = "Guns Products", Price = 1000
                },
                new Product() 
                {
                    ID = 3, Name = "زبادي", Description = "Food Products", Price = 3
                },
            };
            modelBuilder.Entity<Product>()
                        .HasData(products);

            List<WareHouseProduct> WareHouseProducts = new List<WareHouseProduct>()
            {
                new WareHouseProduct() 
                {ProductID = 1, WareHouseID = 1, MinStock = 10, CurrentStock = 20, MaxStock = 50},
                new WareHouseProduct() 
                {ProductID = 1, WareHouseID = 2, MinStock = 5, CurrentStock = 15, MaxStock = 40},
                new WareHouseProduct() 
                {ProductID = 2, WareHouseID = 3, MinStock = 7, CurrentStock = 12, MaxStock = 30},
                new WareHouseProduct() 
                {ProductID = 2, WareHouseID = 1, MinStock = 3, CurrentStock = 8, MaxStock = 25},
                new WareHouseProduct() 
                {ProductID = 3, WareHouseID = 2, MinStock = 4, CurrentStock = 5, MaxStock = 10},
                new WareHouseProduct() 
                {ProductID = 3, WareHouseID = 3, MinStock = 15, CurrentStock = 20, MaxStock = 50},
            };
            modelBuilder.Entity<WareHouseProduct>()
                        .HasData(WareHouseProducts);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
