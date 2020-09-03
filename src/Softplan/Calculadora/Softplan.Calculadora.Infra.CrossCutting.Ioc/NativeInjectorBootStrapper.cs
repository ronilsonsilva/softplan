using Microsoft.Extensions.DependencyInjection;
using Softplan.Calculadora.Application.Contracts;
using Softplan.Calculadora.Application.Services;
using Softplan.Calculadora.Integration.Contracts;
using Softplan.Calculadora.Integration.Factory;

namespace Softplan.Calculadora.Infra.CrossCutting.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICalculaJurosApplication, CalculaJurosApplication>();
            services.AddScoped<ITaxaIntegration, TaxaIntegration>();
        }
    }
}
