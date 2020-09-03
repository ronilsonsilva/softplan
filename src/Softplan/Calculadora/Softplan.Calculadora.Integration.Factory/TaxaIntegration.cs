using Microsoft.Extensions.Configuration;
using Softplan.Calculadora.Integration.Config;
using Softplan.Calculadora.Integration.Contracts;
using System.Threading.Tasks;

namespace Softplan.Calculadora.Integration.Factory
{
    public class TaxaIntegration : ITaxaIntegration
    {
        private readonly IConfiguration _configuration;

        public TaxaIntegration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<decimal> ObterTaxa()
        {
            decimal taxa = decimal.Parse((await new ClientApiTaxa(_configuration["URL_API_TAXA"]).GetRequest("TaxaJuros")).ToString());
            return taxa;
        }
    }
}
