using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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

        public async Task<bool> ChangePassword(PasswordVM passwordVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + passwordVM.Token);
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var result = await client.PutAsJsonAsync("/api/users/password", passwordVM);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
                return false;
        }

        public async Task<bool> Delete(int id, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await client.DeleteAsync("/api/users/" + id);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ForgotPassword(string Email)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var result = await client.GetAsync("/api/accounts/forgotpassword/?email="+Email);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
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

        public async Task<string> Login(LoginVM loginVM)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            var response = await client.PostAsJsonAsync("/api/accounts/login", loginVM);
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }

        public async Task<bool> Register(RegisterVM registerVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var result = await client.PostAsJsonAsync("/api/accounts/register", registerVM);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        // update your info
        public async Task<bool> Update(AppUserVM appUserVM, string token)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["UrlApi"]);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var result = await client.PutAsJsonAsync("/api/users/"+appUserVM.Id,appUserVM);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        // update info of user by Admin
        public async Task<bool> UpdateUsers(AppUserModelMVC appUserModelMVC, string token)
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
            if (userroles == null)
            {
                return false;
            }
            appUserModelMVC.appUserVM.AppUserRolesId = userroles.Id;
            var result = await client.PutAsJsonAsync("/api/users/" + appUserModelMVC.appUserVM.Id, appUserModelMVC.appUserVM);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
