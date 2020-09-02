using System;
using System.Threading.Tasks;

namespace Softplan.Taxa.Domain.Contracts.Services
{
    public interface ITaxaJurosService
    {
        Task<Decimal> Obter();
    }
}
