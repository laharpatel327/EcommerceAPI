using EcommerceCheckoutAPI.Repositories;
using EcommerceCheckoutAPI.Services;

namespace EcommerceCheckoutAPI
{
    public static class DIExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            return services.AddTransient<ICatalogService, CatalogService>()
                .AddTransient<ICatalogRepository, CatalogRepository>();
        }
    }
}
