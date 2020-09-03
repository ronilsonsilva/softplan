using Softplan.Calculadora.Integration.Config;
using Softplan.Calculadora.Integration.Contracts;
using System.Threading.Tasks;

namespace Softplan.Calculadora.Integration.Factory
{
    public class TaxaIntegration : ITaxaIntegration
    {
        public async Task<decimal> ObterTaxa()
        {
            decimal taxa = decimal.Parse((await new ClientApiTaxa().GetRequest("TaxaJuros")).ToString());
            return taxa;
        }
    }
}
