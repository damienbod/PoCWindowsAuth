using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
                //var client = _clientFactory.CreateClient();

                HttpClientHandler handler = new HttpClientHandler()
                {
                    UseDefaultCredentials = true
                };

                //HttpClient client = new HttpClient(handler);

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(_configurations["MyApiUrl"]);
                    var response = await client.GetAsync("api/MyData");
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await JsonSerializer.DeserializeAsync<List<string>>(
                        await response.Content.ReadAsStreamAsync());

                        return data;
                    }


                    var error = await response.Content.ReadAsStringAsync();
                    throw new ApplicationException($"Status code: {response.StatusCode}, Error: {response.ReasonPhrase}, Message: {error}");
                }

                //var response = await client.GetAsync("api/MyData");
                //if (response.IsSuccessStatusCode)
                //{
                //    var data = await JsonSerializer.DeserializeAsync<List<string>>(
                //    await response.Content.ReadAsStreamAsync());

                //    return data;
                //}

            }
            catch (Exception e)
            {
                throw new ApplicationException($"Exception {e}");
            }
        }
    }
}
