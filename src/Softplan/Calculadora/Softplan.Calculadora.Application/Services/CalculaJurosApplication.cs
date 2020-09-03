using Softplan.Calculadora.Application.Contracts;
using Softplan.Calculadora.Domain.Commands;
using Softplan.Calculadora.Domain.Services;
using Softplan.Calculadora.Integration.Contracts;
using System.Threading.Tasks;

namespace Softplan.Calculadora.Application.Services
{
    public class CalculaJurosApplication : ICalculaJurosApplication
    {
        private readonly ITaxaIntegration _taxaIntegration;

        public CalculaJurosApplication(ITaxaIntegration taxaIntegration)
        {
            _taxaIntegration = taxaIntegration;
        }

        public async Task<decimal> Calcula(CalculaJurosCommand command)
        {
            decimal taxa = await this._taxaIntegration.ObterTaxa();
            return CalculadoraService.CalculaJuros(command.ValorInicial, taxa, command.Tempo);
        }
    }
}
