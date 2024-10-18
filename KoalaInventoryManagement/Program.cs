using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using Inventory.Repository.Repositories;
using KoalaInventoryManagement.Services;
using KoalaInventoryManagement.Services.Filteration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace KoalaInventoryManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

			// Configure the database context with SQL Server
			builder.Services.AddDbContext<InventoryDbContext>(op =>
				op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"), b => b.MigrationsAssembly("Inventory.Data")));

			// Configure Identity
			builder.Services.AddIdentity<ApplicationUser, IdentityRole>(config =>
			{
				config.Password.RequiredUniqueChars = 2;
				config.Password.RequireDigit = true;
				config.Password.RequireLowercase = true;
				config.Password.RequireUppercase = true;
				config.Password.RequireNonAlphanumeric = true;
				config.Password.RequiredLength = 6;
				config.User.RequireUniqueEmail = true;
				config.Lockout.AllowedForNewUsers = true;
				config.Lockout.MaxFailedAccessAttempts = 3;
				config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
			})
			.AddEntityFrameworkStores<InventoryDbContext>()
			.AddDefaultTokenProviders();

			builder.Services.AddAuthorization(options =>
			{
				options.AddPolicy("Admin", policy =>
					policy.RequireRole("Admin")); // Require 'Admin' role for the policy
			});

			// Configure application cookie
			builder.Services.ConfigureApplicationCookie(options =>
			{
				options.Cookie.HttpOnly = true;
				options.ExpireTimeSpan = TimeSpan.FromMinutes(300);
				options.SlidingExpiration = true;
				options.LoginPath = "/Account/Login";
				options.LogoutPath = "/Account/Logout";
				options.AccessDeniedPath = "/Account/AccessDenied";
				options.Cookie.Name = "HamadaCookies";
				options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
				options.Cookie.SameSite = SameSiteMode.Strict;
			});

			// Add session services
			builder.Services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(300); // Set the timeout duration
				options.Cookie.HttpOnly = true; // Make the session cookie HTTP only
				options.Cookie.IsEssential = true; // Make the session cookie essential
			});

			// Register repositories in the unit of work
			builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
			builder.Services.AddTransient<IProductFilterService, ProductsFilterService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();
			app.UseRouting();
			// RotativaConfiguration.Setup(app.Environment.WebRootPath, "/usr/local/bin/");
			// RotativaConfiguration.Setup(app.Environment.WebRootPath, "/usr/local/bin/wkhtmltopdf");
			// RotativaConfiguration.Setup(app.Environment.WebRootPath, "Rotativa/wkhtmltopdf");
			// RotativaConfiguration.Setup("/usr/local/bin/wkhtmltopdf");


			app.UseSession(); // Enable session middleware here
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
