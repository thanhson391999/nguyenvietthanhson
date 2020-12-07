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

namespace Vehicle_Appraisal_WebMVC.Service
{
    public class UserServiceApiClient : IUserServiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IUserRoleServiceApiClient _userRoleServiceApiClient;

        public UserServiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IUserRoleServiceApiClient userRoleServiceApiClient)
        {
            _configuration = configuration;
            _userRoleServiceApiClient = userRoleServiceApiClient;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResultVM<string>> ChangePassword(PasswordVM passwordVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + passwordVM.Token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PutAsJsonAsync("/api/users/password", passwordVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.DeleteAsync("/api/users/" + id);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> ForgotPassword(string Email)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/accounts/password-forgot/?email=" + Email);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<List<AppUserModelMVC>> GetAll(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.GetAsync("/api/users");
            var body = await response.Content.ReadAsStringAsync();
            var appuserVM = JsonConvert.DeserializeObject<List<AppUserVM>>(body);
            var appuserroleVM = await _userRoleServiceApiClient.GetAll(token);
            var list = (from _user in appuserVM
                        join _userrole in appuserroleVM on _user.AppUserRolesId equals _userrole.Id into userroles
                        from _userroles in userroles.DefaultIfEmpty()
                        select new AppUserModelMVC
                        {
                            appUserRoleVM = _userroles,
                            appUserVM = _user
                        }).ToList();
            return list;
        }

        public async Task<List<AppUserVM>> GetAllNotDelete(string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.GetAsync("/api/users/not-delete");
            var body = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<AppUserVM>>(body);
            return list;
        }

        public async Task<PageResultVM<AppUserModelMVC>> GetAllPaging(string token, PaginationVM paginationVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.GetAsync("/api/users/paging/?pageIndex=" + paginationVM.PageIndex);
            var body = await response.Content.ReadAsStringAsync();
            var pageResult = JsonConvert.DeserializeObject<PageResultVM<AppUserVM>>(body);
            var appuserroleVM = await _userRoleServiceApiClient.GetAll(token);
            var listAppUserModelMVC = (from _user in pageResult.Items
                        join _userrole in appuserroleVM on _user.AppUserRolesId equals _userrole.Id into userroles
                        from _userroles in userroles.DefaultIfEmpty()
                        select new AppUserModelMVC
                        {
                            appUserRoleVM = _userroles,
                            appUserVM = _user
                        }).ToList();
            return new PageResultVM<AppUserModelMVC>
            {
                Items = listAppUserModelMVC,
                PageIndex = pageResult.PageIndex,
                PageSize = pageResult.PageSize,
                TotalRecord = pageResult.TotalRecord
            };
        }

        public async Task<AppUserModelMVC> GetById(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.GetAsync("/api/users/" + id);
            var body = await response.Content.ReadAsStringAsync();
            var appuserVM = JsonConvert.DeserializeObject<AppUserVM>(body);
            if (appuserVM == null)
            {
                return null;
            }
            var appuserroleVM = await _userRoleServiceApiClient.GetById(appuserVM.AppUserRolesId, token);
            var appUserModelMVC = new AppUserModelMVC
            {
                appUserVM = appuserVM,
                appUserRoleVM = appuserroleVM
            };
            return appUserModelMVC;
        }

        public async Task<ApiResultVM<string>> Login(LoginVM loginVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/accounts/login", loginVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        public async Task<ApiResultVM<string>> Register(RegisterVM registerVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.PostAsJsonAsync("/api/accounts/register", registerVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        // update your info
        public async Task<ApiResultVM<string>> Update(AppUserVM appUserVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.PutAsJsonAsync("/api/users/" + appUserVM.Id, appUserVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }

        // update info of user by Admin
        public async Task<ApiResultVM<string>> UpdateUsers(AppUserModelMVC appUserModelMVC, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var userrole = await _userRoleServiceApiClient.GetAll(token);
            var userroles = (from u in userrole
                             select new AppUserRoleVM
                             {
                                 Id = u.Id,
                                 Name = u.Name
                             }).SingleOrDefault(x => x.Name.Equals(appUserModelMVC.appUserRoleVM.Name));
            appUserModelMVC.appUserVM.AppUserRolesId = userroles.Id;
            var response = await client.PutAsJsonAsync("/api/users/" + appUserModelMVC.appUserVM.Id, appUserModelMVC.appUserVM);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResultVM<string>>(body);
        }
    }
}
