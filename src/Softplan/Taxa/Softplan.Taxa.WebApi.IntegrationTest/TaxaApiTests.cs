using Newtonsoft.Json;
using Softplan.Taxa.WebApi.IntegrationTest.Configs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Taxa.WebApi.IntegrationTest
{
    [TestCaseOrderer("Features.Tests.PriorityOrderer", "Features.Tests")]
    [Collection(nameof(IntegrationTaxaApiFixtureCollection))]
    public class TaxaApiTests
    {
        private readonly IntegrationTestsFixture<StartupTest> _testsFixture;

        public TaxaApiTests(IntegrationTestsFixture<StartupTest> testsFixture)
        {
            _testsFixture = testsFixture;
        }


        [Fact(DisplayName = "Obter Taxa de Juros - Retorna Status OK")]
        public async Task ObterTaxaJuros_DeveReornar_StatusCode_200()
        {
            // Arrange

            // Act
            var postResponse = await _testsFixture.Client.GetAsync("api/TaxaJuros");

            // Assert
            postResponse.EnsureSuccessStatusCode();
        }
        
        [Fact(DisplayName = "Obter Taxa de Juros - Retorna 0.01")]
        public async Task ObterTaxaJuros_DeveReornar_Taxa()
        {
            // Act
            var postResponse = await _testsFixture.Client.GetAsync("api/TaxaJuros");

            // Assert
            var retorno = await postResponse.Content.ReadAsStringAsync();
            decimal vlr = decimal.Parse(retorno.Replace(".",","));

            Assert.Equal((Decimal)0.01, vlr);
        }
    }
}
