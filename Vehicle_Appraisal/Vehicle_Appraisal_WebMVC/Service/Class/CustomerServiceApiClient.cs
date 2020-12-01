using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Service.Class
{
    public class CustomerServiceApiClient : ICustomerServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CustomerServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResultVM<string>> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.DeleteAsync("/api/Customers/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<CustomerVM>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/customers");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<CustomerVM>>(body);
            return list;
        }

        public async Task<List<CustomerVM>> GetAllNotDelete(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/customers/not-delete");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<CustomerVM>>(body);
            return list;
        }

        public async Task<CustomerVM> GetById(int Id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/customers/" + Id);
            var body = await response.Content.ReadAsStringAsync();
            var customerVM = JsonConvert.DeserializeObject<CustomerVM>(body);
            return customerVM;
        }

        public async Task<ApiResultVM<string>> Insert(CustomerVM customerVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/customers", customerVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<CustomerVM>> Search(string token, string name, string phone, string email, string address, string city, string country)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/customers/info?name="+name+"&phone="+phone+"&email="+email+"&address="+address+"&city="+city+"&country="+country);
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<CustomerVM>>(body);
            return list;
        }

        public async Task<ApiResultVM<string>> Update(CustomerVM customerVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PutAsJsonAsync("/api/customers/" + customerVM.Id, customerVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }
    }
}
