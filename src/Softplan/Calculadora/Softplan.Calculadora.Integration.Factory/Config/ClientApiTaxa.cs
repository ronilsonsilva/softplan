using RestSharp;
using System;
using System.Threading.Tasks;

namespace Softplan.Calculadora.Integration.Config
{
    public class ClientApiTaxa
    {
        private readonly RestClient _client;

        public ClientApiTaxa()
        {
            this._client = new RestClient("https://localhost:44364/api/");
        }

        public async Task<Object> GetRequest(string uri, Parameter[] parameters = null)
        {
            RestRequest restRequest = new RestRequest(uri, DataFormat.Json);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    restRequest.AddParameter(parameter);
                }
            }

            return await this._client.GetAsync<Object>(restRequest);
        }
    }
}
