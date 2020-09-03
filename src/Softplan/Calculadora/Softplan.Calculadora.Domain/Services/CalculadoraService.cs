using Softplan.Calculadora.Domain.Extensions;
using System;

namespace Softplan.Calculadora.Domain.Services
{
    public static class CalculadoraService
    {
        public static decimal CalculaJuros(decimal valorInicial, decimal juros, int tempo)
        {
            decimal valorFinal = Decimal.Multiply(valorInicial, (decimal)Math.Pow((double)(1 + juros), tempo));
            return valorFinal.Truncate2();
        }

    }
}
