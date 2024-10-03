using Microsoft.Extensions.DependencyInjection;
using Inventory.Repository.Repositories;
using Inventory.Repository.Interfaces;

namespace Inventory.Services
{
    public static class ServiceRegistration
    {
        // This is an extension method for IServiceCollection
        //ml a5er el bnktbo hna bytzwd 3l services fl program.cs
        public static void AddUnitOfWork(this IServiceCollection services)
        {
            // Register your repositories here
            services.AddTransient<IUnitOfWork,UnitOfWork>();
        }
    }
}
