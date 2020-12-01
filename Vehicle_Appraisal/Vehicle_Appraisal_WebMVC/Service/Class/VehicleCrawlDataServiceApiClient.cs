using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Service.Class
{
    public class VehicleCrawlDataServiceApiClient : IVehicleCrawlDataServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public VehicleCrawlDataServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<VehicleCrawlDataVM>> GetAllVehicleCrawlData(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<VehicleCrawlDataVM>>(body);
            return list;
        }
    }
}
