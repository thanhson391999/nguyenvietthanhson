using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string email, string htmlContent, string subject);
        Task<bool> ConfirmEmail(string token);
        Task<bool> ResetPassword(PasswordVM passwordVM);
    }
}
