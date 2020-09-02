using Softplan.Taxa.Application.Contracts;
using Softplan.Taxa.Domain.Contracts.Services;
using System.Threading.Tasks;

namespace Softplan.Taxa.Application.Services
{
    public class TaxaJurosApplication : ITaxaJurosApplication
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosApplication(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public async Task<decimal> Obter()
        {
            return await this._taxaJurosService.Obter();
        }
    }
}
