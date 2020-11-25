using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string email,string htmlContent, string subject);
        Task<bool> ConfirmEmail(string token);
        Task<bool> ResetPassword(PasswordVM passwordVM);
    }
}
