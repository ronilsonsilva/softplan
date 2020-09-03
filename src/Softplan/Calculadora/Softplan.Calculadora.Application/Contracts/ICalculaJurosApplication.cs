using Softplan.Calculadora.Domain.Commands;
using System.Threading.Tasks;

namespace Softplan.Calculadora.Application.Contracts
{
    public interface ICalculaJurosApplication
    {
        Task<decimal> Calcula(CalculaJurosCommand command);
    }
}
