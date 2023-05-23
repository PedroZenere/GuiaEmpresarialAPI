using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace GuiaEmpresarialAPI.Server.Configurations
{
    public static class DependencyInjections
    {
        public static void RegisterServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IApplicationContext, ApplicationContext>();
        }
    }
}
