using Microsoft.Extensions.DependencyInjection;
using Softplan.Taxa.Application.Contracts;
using Softplan.Taxa.Application.Services;
using Softplan.Taxa.Domain.Contracts.Repository;
using Softplan.Taxa.Domain.Contracts.Services;
using Softplan.Taxa.Domain.Services;
using Softplan.Taxa.Infra.Data.Repository.Repository;

namespace Softplan.Taxa.Infra.CrossCutting.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ITaxaJurosApplication, TaxaJurosApplication>();
            services.AddScoped<ITaxaJurosService, TaxaJurosService>();
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();
        }
    }
}
