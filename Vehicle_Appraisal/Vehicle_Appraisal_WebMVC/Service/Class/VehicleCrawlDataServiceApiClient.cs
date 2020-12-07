using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleBMWCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/bmw/paging/?pageIndex="+ paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleAudiCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/audi/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleFordCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/ford/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHondaCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/honda/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHyundaiCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/hyundai/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleLexusCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/lexus/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleMitsubishiCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/mitsubishi/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleSuzukiCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/suzuki/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleToyotaCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/toyota/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }

        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleVinfastCrawlData(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/VehicleCrawlDatas/vinfast/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<VehicleCrawlDataVM>>(body);
            return pageResult;
        }
    }
}
