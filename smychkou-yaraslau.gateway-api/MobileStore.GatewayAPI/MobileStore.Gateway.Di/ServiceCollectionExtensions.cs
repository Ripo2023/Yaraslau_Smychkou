using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Bll.Services;
using MobileStore.Gateway.Common.Configs;
using MobileStore.Gateway.Dal.Interfaces;
using MobileStore.Gateway.Dal.Repositories;

namespace MobileStore.Gateway.Di
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(Options.Create(new DatabaseOptions
            {
                DefaultConnection = configuration.GetConnectionString("DefaultConnection")
            }));

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
