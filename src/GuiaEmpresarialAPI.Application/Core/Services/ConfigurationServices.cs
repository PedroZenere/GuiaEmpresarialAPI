using GuiaEmpresarialAPI.Application.Categorias.Commands.Services;
using GuiaEmpresarialAPI.Application.Categorias.Queries.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Core.Services
{
    public static class ConfigurationServices
    {
        public static void ConfigurationHandlerServices(this IServiceCollection services)
        {
            //Categorias
            services.AddScoped<ICategoriaCommandServices, CategoriaCommandServices>();
            services.AddScoped<ICategoriaQueriesServices, CategoriaQueriesServices>();
        }
    }
}
