using Softplan.Calculadora.Domain.Commands;
using Softplan.Calculadora.WebApi.IntegrationTest.Configs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;

namespace Softplan.Calculadora.WebApi.IntegrationTests
{
    [TestCaseOrderer("Features.Tests.PriorityOrderer", "Features.Tests")]
    [Collection(nameof(IntegrationCalculadoraApiFixtureCollection))]
    public class CalculadoraApiTest
    {
        private readonly IntegrationTestsFixture<StartupTest> _testsFixture;

        public CalculadoraApiTest(IntegrationTestsFixture<StartupTest> testsFixture)
        {
            _testsFixture = testsFixture;
        }


        [Fact(DisplayName = "Calcula Juros - Retorna Status OK")]
        public async Task CalculaJuros_DeveReornar_StatusCode_200()
        {
            // Arrange
            var command = new CalculaJurosCommand()
            {
                Tempo = 5,
                ValorInicial = 100
            };

            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/CalculaJuros", command);

            // Assert
            postResponse.EnsureSuccessStatusCode();
        }

        [Fact(DisplayName = "Calcula Juros - Retorna os valores inline")]
        public async Task ObterTaxaJuros_DeveReornar_Taxa()
        {
            // Arrange
            var command = new CalculaJurosCommand()
            {
                Tempo = 5,
                ValorInicial = 100
            };

            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/CalculaJuros", command);

            // Assert
            var retorno = await postResponse.Content.ReadAsStringAsync();
            decimal vlr = decimal.Parse(retorno.Replace(".", ","));

            Assert.Equal((decimal)105.10, vlr);
        }
    }
}
