using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IUserRoleService
    {
        Task<List<AppUserRoleVM>> GetAll();
        Task<AppUserRoleVM> GetById(int id);
    }
}
