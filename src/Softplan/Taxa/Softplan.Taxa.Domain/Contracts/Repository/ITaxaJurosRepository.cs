using System;
using System.Threading.Tasks;

namespace Softplan.Taxa.Domain.Contracts.Repository
{
    public interface ITaxaJurosRepository
    {
        Task<Decimal> Obter();
    }
}
