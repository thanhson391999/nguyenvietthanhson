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
    public class ModelServiceApiClient : IModelServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration; 

        public ModelServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResultVM<string>> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.DeleteAsync("/api/models/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<ModelVM>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/models");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<ModelVM>>(body);
            return list; 
        }

        public async Task<List<ModelVM>> GetAllNotDelete(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/models/not-delete");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<ModelVM>>(body);
            return list;
        }

        public async Task<ModelVM> GetById(int Id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/models/"+Id);
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<ModelVM>(body);
            return list;
        }

        public async Task<ApiResultVM<string>> Insert(ModelVM modelVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/models", modelVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> Update(ModelVM modelVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PutAsJsonAsync("/api/models/"+modelVM.Id, modelVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }
    }
}
