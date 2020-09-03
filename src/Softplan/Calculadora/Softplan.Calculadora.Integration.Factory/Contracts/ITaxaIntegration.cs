using System.Threading.Tasks;

namespace Softplan.Calculadora.Integration.Contracts
{
    public interface ITaxaIntegration
    {
        Task<decimal> ObterTaxa();
    }
}
