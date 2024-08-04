using GuiaEmpresarialAPI.Data.Context;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Data.UOW;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace GuiaEmpresarialAPI.Server.Configurations
{
    public class InfrastructureServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApplicationContext, ApplicationContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

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

            CheckConnectionDatabase(services);
            RunMigrations(services);
        }

        public static void CheckConnectionDatabase(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var db = serviceProvider.GetRequiredService<ApplicationContext>())
            {
                if (db.Database.CanConnect())
                { //CanConnect can be exposed in most classes inheriting DbContext
                    Console.WriteLine("Connection successful.");
                    db.Database.EnsureCreated();
                    return;
                }
                throw new Exception("Could not connect to database.");
            }
        }

        public static void RunMigrations(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var db = serviceProvider.GetRequiredService<ApplicationContext>())
            {
                db.Database.Migrate();
            }
        }
    }
}
