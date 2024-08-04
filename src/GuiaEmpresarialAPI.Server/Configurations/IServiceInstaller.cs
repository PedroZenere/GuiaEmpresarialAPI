using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GuiaEmpresarialAPI.Server.Configurations
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}
