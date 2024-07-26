using Microsoft.Extensions.DependencyInjection;
using GestionInventarioDAL.Interfaces;

namespace GestionInventarioDAL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryConnector(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            return services;
        }
    }
}
