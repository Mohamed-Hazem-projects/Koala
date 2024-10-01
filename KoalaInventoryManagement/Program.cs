using KoalaInventoryManagement.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace KoalaInventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Inventory Services
            //DbContext service for DB connection
            builder.Services.AddDbContext<InventoryDBContext>(
                opt => opt.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnectionString")
                    )
                );
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
