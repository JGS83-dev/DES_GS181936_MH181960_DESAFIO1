using GestionInventarioBL.Automapper;
using GestionInventarioBL.Interfaces;
using GestionInventarioDAL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GestionInventarioBL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            services.AddTransient<IProductoService, ProductoService>();
            services.AddRepositoryConnector();
            return services;

        }
    }
}
