using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Service.Class
{
    public class VehicleServiceApiClient : IVehicleServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public VehicleServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResultVM<string>> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.DeleteAsync("/api/vehicles/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<VehicleVM>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles");
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<VehicleVM>>(body);
        }

        public async Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/" + id + "/appraisal-values");
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<VehicleAppraisalVM>>(body);
        }

        public async Task<VehicleVM> GetById(int Id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/" + Id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VehicleVM>(body);
        }

        public async Task<ApiResultVM<string>> Insert(VehicleVM vehicleVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/vehicles", vehicleVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> Update(VehicleVM vehicleVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PutAsJsonAsync("/api/vehicles/" + vehicleVM.Id, vehicleVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> BuyVehicle(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.DeleteAsync("/api/vehicles/vehicle-buy/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<PageResultVM<VehicleVM>> GetAllVehicleBoughtPaging(string token, DateTime fromDate, DateTime toDate, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/vehicle-bought/paging/?pageIndex=" + paginationVM.PageIndex +"&fromDate="+ fromDate +"&toDate="+ toDate);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PageResultVM<VehicleVM>>(body);
        }

        public async Task<PageResultVM<VehicleVM>> GetAllPaging(string token, PaginationSearchVM paginationSearchVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/paging/?pageIndex=" + paginationSearchVM.PageIndex + "&keyWord=" + paginationSearchVM.keyWord + "&subjects=" + paginationSearchVM.subjects);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PageResultVM<VehicleVM>>(body);
        }

        public async Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(string token, int id, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/"+ id +"/conditions/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PageResultVM<ConditionVM>>(body);
        }

        public async Task<List<VehicleVM>> GetAllVehicleBought(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/vehicle-bought");
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<VehicleVM>>(body);
        }

        public async Task<List<VehicleVM>> GetAllNotBuy(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/not-buy");
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<VehicleVM>>(body);
        }
    }
}
