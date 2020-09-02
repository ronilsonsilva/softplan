using Softplan.Taxa.Domain.Contracts.Repository;
using System;
using System.Threading.Tasks;

namespace Softplan.Taxa.Infra.Data.Repository.Repository
{
    public class TaxaJurosRepository : ITaxaJurosRepository
    {
        public async Task<decimal> Obter()
        {
            return Decimal.Parse("0,1");
        }
    }
}
