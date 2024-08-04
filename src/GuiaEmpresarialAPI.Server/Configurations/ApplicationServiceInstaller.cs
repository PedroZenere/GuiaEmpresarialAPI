using GuiaEmpresarialAPI.Application;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GuiaEmpresarialAPI.Server.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            var applicationAssembly = Assembly.Load("GuiaEmpresarialAPI.Application");
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));
            services.AddAutoMapper(applicationAssembly);
        }
    }
}
