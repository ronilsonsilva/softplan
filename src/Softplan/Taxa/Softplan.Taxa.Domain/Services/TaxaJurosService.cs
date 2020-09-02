using Softplan.Taxa.Domain.Contracts.Repository;
using Softplan.Taxa.Domain.Contracts.Services;
using System.Threading.Tasks;

namespace Softplan.Taxa.Domain.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;

        public TaxaJurosService(ITaxaJurosRepository taxaJurosRepository)
        {
            _taxaJurosRepository = taxaJurosRepository;
        }

        public async Task<decimal> Obter()
        {
            return await this._taxaJurosRepository.Obter();
        }
    }
}
