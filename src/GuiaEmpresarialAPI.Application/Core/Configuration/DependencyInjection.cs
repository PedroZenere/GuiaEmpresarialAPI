using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace GuiaEmpresarialAPI.Application.Core.Configuration
{
    public static class DependencyInjection
    {
        public static void AddServiceMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }

        public static void AddServiceAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
