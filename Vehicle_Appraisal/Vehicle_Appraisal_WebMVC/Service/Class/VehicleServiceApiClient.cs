using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Service.Class
{
    public class VehicleServiceApiClient : IVehicleServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICustomerServiceApiClient _customerServiceApiClient;
        private readonly IMakeServiceApiClient _makeServiceApiClient;
        private readonly IModelServiceApiClient _modelServiceApiClient;
        private readonly IUserServiceApiClient _userServiceApiClient;
        private readonly IVehicleAppraisalServiceApiClient _vehicleAppraisalServiceApiClient;
        private readonly IConfiguration _configuration;

        public VehicleServiceApiClient(IHttpClientFactory httpClientFactory, IVehicleAppraisalServiceApiClient vehicleAppraisalServiceApiClient, IUserServiceApiClient userServiceApiClient, IConfiguration configuration,ICustomerServiceApiClient customerServiceApiClient, IMakeServiceApiClient makeServiceApiClient, IModelServiceApiClient modelServiceApiClient)
        {
            _vehicleAppraisalServiceApiClient = vehicleAppraisalServiceApiClient;
            _userServiceApiClient = userServiceApiClient;
            _configuration = configuration;
            _customerServiceApiClient = customerServiceApiClient;
            _makeServiceApiClient = makeServiceApiClient;
            _modelServiceApiClient = modelServiceApiClient;
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

        private async Task<List<VehicleModelMVC>> ReturnListVehicle(List<VehicleVM> vehicleVMs, string token)
        {
            var customer = await _customerServiceApiClient.GetAll(token);
            var make = await _makeServiceApiClient.GetAll(token);
            var model = await _modelServiceApiClient.GetAll(token);
            var appUser = await _userServiceApiClient.GetAll(token);
            var list = (from _vehicle in vehicleVMs
                        join _customer in customer on _vehicle.CustomerId equals _customer.Id into customers
                        from _customers in customers.DefaultIfEmpty()
                        join _make in make on _vehicle.MakeId equals _make.Id into makes
                        from _makes in makes.DefaultIfEmpty()
                        join _model in model on _vehicle.ModelId equals _model.Id into models
                        from _models in models.DefaultIfEmpty()
                        join _appUser in appUser on _vehicle.AppUserId equals _appUser.appUserVM.Id into appUsers
                        from _appUsers in appUsers.DefaultIfEmpty()
                        select new VehicleModelMVC
                        {
                            makeVM = _makes,
                            customerVM = _customers,
                            vehicleVM = _vehicle,
                            modelVM = _models,
                            appUserVM = _appUsers.appUserVM
                        }).ToList();
            return list;
        }

        public async Task<List<VehicleModelMVC>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles");
            var body = await response.Content.ReadAsStringAsync();
            var vehicle = JsonConvert.DeserializeObject<List<VehicleVM>>(body);
            return await ReturnListVehicle(vehicle, token);
        }

        public async Task<List<ConditionVM>> GetAllConditionById(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/" + id + "/conditions");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<ConditionVM>>(body);
            return list;
        }

        public async Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/" + id + "/appraisalvalues");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<VehicleAppraisalVM>>(body);
            return list;
        }

        public async Task<VehicleModelMVC> GetById(int Id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/" + Id);
            var body = await response.Content.ReadAsStringAsync();
            var vehicle = JsonConvert.DeserializeObject<VehicleVM>(body);
            if (vehicle == null)
            {
                return null;
            }
            var customerGetById = await _customerServiceApiClient.GetById(vehicle.CustomerId, token);
            var makeGetById = await _makeServiceApiClient.GetById(vehicle.MakeId, token);
            var modelGetById = await _modelServiceApiClient.GetById(vehicle.ModelId, token);
            var appuserGetById = await _userServiceApiClient.GetById(vehicle.AppUserId, token);
            var vehicleModelMVC = new VehicleModelMVC
            {
                makeVM = makeGetById,
                customerVM = customerGetById,
                vehicleVM = vehicle,
                modelVM = modelGetById,
                appUserVM = appuserGetById.appUserVM
            };
            return vehicleModelMVC;
        }

        public async Task<ApiResultVM<string>> Insert(VehicleModelMVC vehicleModelMVC, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var customer = await _customerServiceApiClient.GetAll(token);
            var make = await _makeServiceApiClient.GetAll(token);
            var model = await _modelServiceApiClient.GetAll(token);
            var appuser = await _userServiceApiClient.GetAll(token);
            var customers = (from c in customer
                             select new CustomerVM
                             {
                                 Id = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName
                             }).SingleOrDefault(x => (x.FirstName + x.LastName).Equals(vehicleModelMVC.customerVM.FirstName + vehicleModelMVC.customerVM.LastName));
            var makes = (from m in make
                         select new MakeVM
                         {
                             Id = m.Id,
                             Name = m.Name
                         }).SingleOrDefault(x => x.Name.Equals(vehicleModelMVC.makeVM.Name));
            var models = (from m in model
                          select new ModelVM
                          {
                              Id = m.Id,
                              Name = m.Name
                          }).SingleOrDefault(x => x.Name.Equals(vehicleModelMVC.modelVM.Name));
            var appusers = (from a in appuser
                            select new AppUserVM
                            {
                                Id = a.appUserVM.Id,
                                FullName = a.appUserVM.FullName
                            }).SingleOrDefault(x => x.FullName.Equals(vehicleModelMVC.appUserVM.FullName));
            if (customers == null)
            {
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            var vehicleModel = new VehicleVM()
            {
                CustomerId = customers.Id,
                MakeId = makes.Id,
                ModelId = models.Id,
                AppUserId = appusers.Id,
                Engine = vehicleModelMVC.vehicleVM.Engine,
                Odometer = vehicleModelMVC.vehicleVM.Odometer,
                VIN = vehicleModelMVC.vehicleVM.VIN
            };
            var response = await client.PostAsJsonAsync("/api/vehicles", vehicleModel);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<VehicleModelMVC>> Search(string token, string Customer, string Make, string Model, string odometer, string VIN, string engine, string Appuser)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var customer = await _customerServiceApiClient.GetAll(token);
            var make = await _makeServiceApiClient.GetAll(token);
            var model = await _modelServiceApiClient.GetAll(token);
            var appuser = await _userServiceApiClient.GetAll(token);
            string makeID = null;
            string modelID = null;
            string customerID = null;
            string appuserID = null;
            if (Customer != null)
            {
                var customerId = (from c in customer
                                  select new CustomerVM
                                  {
                                      Id = c.Id,
                                      FirstName = c.FirstName,
                                      LastName = c.LastName
                                  }).Where(x => (x.FirstName + " " + x.LastName).Equals(Customer)).FirstOrDefault();
                if (customerId != null)
                {
                    customerID = customerId.Id.ToString();
                }
            }
            if (Make != null)
            {
                var makeId = (from m in make
                              select new MakeVM
                              {
                                  Id = m.Id,
                                  Name = m.Name
                              }).Where(x => x.Name.Equals(Make)).FirstOrDefault();
                if (makeId != null)
                {
                    makeID = makeId.Id.ToString();
                }
            }
            if (Model != null)
            {
                var modelId = (from m in model
                               select new ModelVM
                               {
                                   Id = m.Id,
                                   Name = m.Name
                               }).Where(x => x.Name.Equals(Model)).FirstOrDefault();
                if (modelId != null)
                {
                    modelID = modelId.Id.ToString();
                }
            }
            if (Appuser != null)
            {
                var appuserId = (from a in appuser
                                 select new AppUserVM
                                 {
                                     Id = a.appUserVM.Id,
                                     FullName = a.appUserVM.FullName
                                 }).Where(x => x.FullName.Equals(Appuser)).FirstOrDefault();
                if (appuserId != null)
                {
                    appuserID = appuserId.Id.ToString();
                }
            }
            var response = await client.GetAsync("/api/vehicles/info?customerId="+customerID+"&makeId="+makeID+"&modelId="+modelID+"&odometer="+odometer+"&VIN="+VIN+"&engine="+engine+"&appuserId="+appuserID);
            var body = await response.Content.ReadAsStringAsync();
            var vehicle = JsonConvert.DeserializeObject<List<VehicleVM>>(body);
            return await ReturnListVehicle(vehicle, token);
        }

        public async Task<ApiResultVM<string>> Update(VehicleModelMVC vehicleModelMVC, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var customer = await _customerServiceApiClient.GetAll(token);
            var make = await _makeServiceApiClient.GetAll(token);
            var model = await _modelServiceApiClient.GetAll(token);
            var appuser = await _userServiceApiClient.GetAll(token);
            var customers = (from c in customer
                             select new CustomerVM
                             {
                                 Id = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName
                             }).SingleOrDefault(x => (x.FirstName + x.LastName).Equals(vehicleModelMVC.customerVM.FirstName + vehicleModelMVC.customerVM.LastName));
            var makes = (from m in make
                         select new MakeVM
                         {
                             Id = m.Id,
                             Name = m.Name
                         }).SingleOrDefault(x => x.Name.Equals(vehicleModelMVC.makeVM.Name));
            var models = (from m in model
                          select new ModelVM
                          {
                              Id = m.Id,
                              Name = m.Name
                          }).SingleOrDefault(x => x.Name.Equals(vehicleModelMVC.modelVM.Name));
            var appusers = (from a in appuser
                             select new AppUserVM
                             {
                                 Id = a.appUserVM.Id,
                                 FullName = a.appUserVM.FullName
                             }).SingleOrDefault(x => x.FullName.Equals(vehicleModelMVC.appUserVM.FullName));
            if (customers == null)
            {
                return new ApiErrorResultVM<string>("Customer doesn't exist");
            }
            vehicleModelMVC.vehicleVM.CustomerId = customers.Id;
            vehicleModelMVC.vehicleVM.MakeId = makes.Id;
            vehicleModelMVC.vehicleVM.ModelId = models.Id;
            vehicleModelMVC.vehicleVM.AppUserId = appusers.Id;
            var response = await client.PutAsJsonAsync("/api/vehicles/" + vehicleModelMVC.vehicleVM.Id, vehicleModelMVC.vehicleVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> BuyVehicle(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/buyvehicle/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        private async Task<List<VehicleModelMVC>> ReturnListVehicleBought(List<VehicleVM> vehicleVMs, string token)
        {
            var customer = await _customerServiceApiClient.GetAll(token);
            var make = await _makeServiceApiClient.GetAll(token);
            var model = await _modelServiceApiClient.GetAll(token);
            var appUser = await _userServiceApiClient.GetAll(token);
            var vehicleAppraisal = await _vehicleAppraisalServiceApiClient.GetAll(token);
            var list = (from _vehicle in vehicleVMs
                        join _customer in customer on _vehicle.CustomerId equals _customer.Id into customers
                        from _customers in customers.DefaultIfEmpty()
                        join _make in make on _vehicle.MakeId equals _make.Id into makes
                        from _makes in makes.DefaultIfEmpty()
                        join _model in model on _vehicle.ModelId equals _model.Id into models
                        from _models in models.DefaultIfEmpty()
                        join _appUser in appUser on _vehicle.AppUserId equals _appUser.appUserVM.Id into appUsers
                        from _appUsers in appUsers.DefaultIfEmpty()
                        join _vehicleAppraisal in vehicleAppraisal on _vehicle.Id equals _vehicleAppraisal.VehicleId into vehicleAppraisals
                        from _vehicleAppraisals in vehicleAppraisals.DefaultIfEmpty()
                        select new VehicleModelMVC
                        {
                            makeVM = _makes,
                            customerVM = _customers,
                            vehicleVM = _vehicle,
                            modelVM = _models,
                            appUserVM = _appUsers.appUserVM,
                            vehicleAppraisalVM = _vehicleAppraisals
                        }).ToList();
            return list;
        }

        public async Task<List<VehicleModelMVC>> GetAllVehicleBought(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/not-buy");
            var body = await response.Content.ReadAsStringAsync();
            var vehicle = JsonConvert.DeserializeObject<List<VehicleVM>>(body);
            return await ReturnListVehicleBought(vehicle, token);
        }

        public async Task<List<VehicleVM>> GetAllNotBuy(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/not-buy");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<VehicleVM>>(body);
            return list;
        }

        public async Task<List<VehicleModelMVC>> SearchDate(DateTime fromDate, DateTime toDate, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/vehicles/date?fromDate="+fromDate.Date+"&toDate="+toDate.Date);
            var body = await response.Content.ReadAsStringAsync();
            var vehicle = JsonConvert.DeserializeObject<List<VehicleVM>>(body);
            return await ReturnListVehicleBought(vehicle, token);
        }
    }
}
