using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IUserRoleServiceApiClient
    {
        Task<List<AppUserRoleVM>> GetAll(string token);
        Task<AppUserRoleVM> GetById(int id, string token);
    }
}
