using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IUserService
    {
        Task<List<AppUserVM>> GetAll();
        Task<AppUserVM> GetUser(string emailorusername);
        Task<AppUserVM> GetById(int id);
        Task<ApiResultVM<string>> Delete(int id);
        Task<ApiResultVM<string>> Update(AppUserVM userVM, int id);
        Task<ApiResultVM<string>> ChangePassword(PasswordVM passwordVM);
    }
}
