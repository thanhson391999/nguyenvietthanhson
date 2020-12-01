using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IUserServiceApiClient
    {
        Task<List<AppUserModelMVC>> GetAll(string token);
        Task<AppUserModelMVC> GetById(int id, string token);
        Task<ApiResultVM<string>> UpdateUsers(AppUserModelMVC appUserModelMVC, string token);

        Task<ApiResultVM<string>> Update(AppUserVM appUserVM, string token);
        Task<ApiResultVM<string>> Delete(int id, string token);
        Task<ApiResultVM<string>> Login(LoginVM loginVM);
        Task<ApiResultVM<string>> Register(RegisterVM registerVM, string token);
        Task<ApiResultVM<string>> ForgotPassword(string email);
        Task<ApiResultVM<string>> ChangePassword(PasswordVM passwordVM);
    }
}
