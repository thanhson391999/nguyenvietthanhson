using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IUserService : IPaginationService<AppUserVM>
    {
        Task<List<AppUserVM>> GetAll();
        Task<List<AppUserVM>> GetAllNotDelete();
        Task<AppUserVM> GetUser(string emailorusername);
        Task<AppUserVM> GetById(int id);
        Task<ApiResultVM<string>> Delete(int id);
        Task<ApiResultVM<string>> Update(AppUserVM userVM, int id);
        Task<ApiResultVM<string>> ChangePassword(PasswordVM passwordVM);
    }
}
