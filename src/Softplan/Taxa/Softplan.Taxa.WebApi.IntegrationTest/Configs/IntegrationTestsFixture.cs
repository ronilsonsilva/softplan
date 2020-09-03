using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace Softplan.Taxa.WebApi.IntegrationTest.Configs
{
    [CollectionDefinition(nameof(IntegrationTaxaApiFixtureCollection))]
    public class IntegrationTaxaApiFixtureCollection : ICollectionFixture<IntegrationTestsFixture<StartupTest>> { }
    public class IntegrationTestsFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly TaxaAppFactory<TStartup> Factory;
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

            Factory = new TaxaAppFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }


        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
