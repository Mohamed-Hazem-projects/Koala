using Microsoft.EntityFrameworkCore;

namespace KoalaInventoryManagement.Models.Context
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() : base()
        { }

        public InventoryDBContext(DbContextOptions options) : base(options)
        { }
    }
}
