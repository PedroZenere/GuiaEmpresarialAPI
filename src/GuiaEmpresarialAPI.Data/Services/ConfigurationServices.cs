using GuiaEmpresarialAPI.Data.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GuiaEmpresarialAPI.Data.Services
{
    public static class ConfigurationServices
    {
        public static void ConfigureMainDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<ApplicationContext>(options =>
            {
                string? connectionString = configuration.GetConnectionString("DefaultConnection");

                SqlConnectionStringBuilder connectionStringBuilder = new(connectionString);

                options.UseSqlServer(
                    connectionStringBuilder.ConnectionString,
                    sqlOptions => sqlOptions.MigrationsHistoryTable("__MigrationHistory")
                );

                // Adicionando logs no console
                options
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                    .UseLoggerFactory(LoggerFactory.Create(builder => { builder.AddConsole(); }));
            });
        }
    }
}
