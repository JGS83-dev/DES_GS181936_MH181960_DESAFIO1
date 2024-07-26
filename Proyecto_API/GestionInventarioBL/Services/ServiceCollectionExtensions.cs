using GestionInventarioBL.Automapper;
using GestionInventarioBL.Interfaces;
using GestionInventarioDAL.Interfaces;
using GestionInventarioDAL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
