using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IAccountService
    {
        Task<ApiResultVM<string>> Login(LoginVM loginVM);
        Task<ApiResultVM<string>> Register(RegisterVM registerVM);
        Task<ApiResultVM<string>> ForgotPassword(string email);
    }
}
