using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Softplan.Calculadora.WebApi.Configuration;

namespace Softplan.Calculadora.WebApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });


            services.AddControllers()
                   .AddNewtonsoftJson(options =>
                                        options.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects
                                        );

            services.AddSwaggerConfiguration();
            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");

            app.UseSwaggerConfiguration();

            app.UseApiConfiguration(env);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            Softplan.Calculadora.Infra.CrossCutting.Ioc.NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
