using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace UI.Services
{
    public class MyDataClientService
    {
        private readonly IConfiguration _configurations;
        private readonly IHttpClientFactory _clientFactory;

        public MyDataClientService(
            IConfiguration configurations,
            IHttpClientFactory clientFactory)
        {
            _configurations = configurations;
            _clientFactory = clientFactory;
        }

        public async Task<List<string>> GetMyData()
        {
            try
            {
                var client = _clientFactory.CreateClient();

                client.BaseAddress = new Uri(_configurations["MyApiUrl"]);


                var response = await client.GetAsync("api/MyData");
                if (response.IsSuccessStatusCode)
                {
                    var data = await JsonSerializer.DeserializeAsync<List<string>>(
                    await response.Content.ReadAsStreamAsync());

                    return data;
                }

                throw new ApplicationException($"Status code: {response.StatusCode}, Error: {response.ReasonPhrase}");
            }
            catch (Exception e)
            {
                throw new ApplicationException($"Exception {e}");
            }
        }
    }
}
