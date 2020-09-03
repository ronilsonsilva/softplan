using Softplan.Calculadora.Domain.Services;
using Xunit;

namespace Softplan.Calculadora.Domain.Tests.Services
{
    public class CalculadoraTests
    {

        [Theory]
        [InlineData(100, 0.01, 5, 105.10)]
        [InlineData(10000, 0.01, 12, 11268.25)]
        [InlineData(1235, 0.01, 24, 1568.12)]
        public void CalcularTaxaJuros(decimal valorInicial, decimal juros, int tempo, decimal resultadoEsperado)
        {
            var resultado = CalculadoraService.CalculaJuros(valorInicial, juros, tempo);
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
