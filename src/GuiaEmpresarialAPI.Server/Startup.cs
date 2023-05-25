using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using GuiaEmpresarialAPI.Data.Services;
using FluentValidation.AspNetCore;
using MediatR;
using GuiaEmpresarialAPI.Application.Core.Command;
using GuiaEmpresarialAPI.Server.Configurations;

namespace GuiaEmpresarialAPI.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Configurando SQLServer
            services.ConfigureMainDatabase(Configuration);

            services.RegisterServicesConfiguration();

            services.AddMediatR(typeof(CreateCommandHandlerBase<,,>).Assembly);
            services.AddAutoMapper(typeof(CreateCommandHandlerBase<,,>).Assembly);

            services.AddControllers()
                    .AddFluentValidation(fvc =>
                            fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GuiaEmpresarialAPI.Server", Version = "v1" });
            });

            services.CheckConnectionDatabase();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GuiaEmpresarialAPI.Server v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
