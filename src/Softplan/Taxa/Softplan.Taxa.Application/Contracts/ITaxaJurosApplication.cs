using System.Threading.Tasks;

namespace Softplan.Taxa.Application.Contracts
{
    public interface ITaxaJurosApplication
    {
        Task<decimal> Obter();
    }
}
