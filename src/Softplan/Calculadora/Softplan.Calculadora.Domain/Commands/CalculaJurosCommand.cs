namespace Softplan.Calculadora.Domain.Commands
{
    public class CalculaJurosCommand
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }
    }
}
