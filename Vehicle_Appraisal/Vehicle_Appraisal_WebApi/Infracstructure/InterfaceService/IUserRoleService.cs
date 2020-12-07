using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IUserRoleService
    {
        Task<List<AppUserRoleVM>> GetAll();
        Task<AppUserRoleVM> GetById(int id);
    }
}
