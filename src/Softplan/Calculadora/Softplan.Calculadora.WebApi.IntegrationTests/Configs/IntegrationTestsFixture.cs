using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace Softplan.Calculadora.WebApi.IntegrationTest.Configs
{
    [CollectionDefinition(nameof(IntegrationCalculadoraApiFixtureCollection))]
    public class IntegrationCalculadoraApiFixtureCollection : ICollectionFixture<IntegrationTestsFixture<StartupTest>> { }
    public class IntegrationTestsFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly CalculadoraAppFactory<TStartup> Factory;
        public HttpClient Client;

        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = true,
                BaseAddress = new Uri("http://localhost"),
                HandleCookies = true,
                MaxAutomaticRedirections = 7
            };

            Factory = new CalculadoraAppFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }


        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
