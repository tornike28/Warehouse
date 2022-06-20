using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace SDK
{
    public class HTTPHelper
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<Options> _options;
        public HTTPHelper(IHttpClientFactory httpClientFactory, IOptions<Options> options)
        {
            //_httpClient = httpClientFactory.CreateClient("WareHouseClient");
            _options = options;
            _httpClient.BaseAddress = new Uri(options.Value.URL);
        }
    }
    public class Options
    {
        public string URL { get; set; }
        public int ClientKey { get; set; }
        public int ClientSecret { get; set; }
    }
}
