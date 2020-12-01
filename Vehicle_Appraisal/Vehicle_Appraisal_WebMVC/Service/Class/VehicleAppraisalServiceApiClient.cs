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
    public class VehicleAppraisalServiceApiClient : IVehicleAppraisalServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public VehicleAppraisalServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResultVM<string>> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.DeleteAsync("/api/vehicleappraisals/"+id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<VehicleAppraisalVM>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var result = await client.GetAsync("/api/vehicleappraisals");
            var body = await result.Content.ReadAsStringAsync();
            var vehicleAppraisal = JsonConvert.DeserializeObject<List<VehicleAppraisalVM>>(body);
            return vehicleAppraisal;
        }

        public async Task<ApiResultVM<string>> Insert(VehicleAppraisalVM vehicleAppraisalVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/vehicleappraisals/",vehicleAppraisalVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> Update(VehicleAppraisalVM vehicleAppraisalVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PutAsJsonAsync("/api/vehicleappraisals/"+vehicleAppraisalVM.Id, vehicleAppraisalVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }
    }
}
