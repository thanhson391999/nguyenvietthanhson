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
        Task<bool> UpdateUsers(AppUserModelMVC appUserModelMVC, string token);

        Task<bool> Update(AppUserVM appUserVM, string token);
        Task<bool> Delete(int id, string token);
        Task<string> Login(LoginVM loginVM);
        Task<bool> Register(RegisterVM registerVM, string token);
        Task<bool> ForgotPassword(string email);
        Task<bool> ChangePassword(PasswordVM passwordVM);
    }
}
