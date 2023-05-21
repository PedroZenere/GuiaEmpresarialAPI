using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using GuiaEmpresarialAPI.Data.Services;
using System.Reflection;
using FluentValidation.AspNetCore;
using MediatR;

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

            services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
            //services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddScoped<IMediator, Mediator>();
            //var assembly1 = AppDomain.CurrentDomain.Load("GuiaEmpresarialAPI.Application");
            //var assembly2 = AppDomain.CurrentDomain.Load("GuiaEmpresarialAPI.Shared");
            //services.AddMediatR(assembly2, assembly1);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddControllers()
                     .AddFluentValidation(fvc =>
                            fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GuiaEmpresarialAPI.Server", Version = "v1" });
            });
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
