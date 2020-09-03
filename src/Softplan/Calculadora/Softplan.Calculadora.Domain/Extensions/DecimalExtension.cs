using System;

namespace Softplan.Calculadora.Domain.Extensions
{
    public static class DecimalExtension
    {
        public static decimal Truncate2(this decimal d)
        {
            return Math.Truncate(d * 100) / 100;
        }
    }
}
