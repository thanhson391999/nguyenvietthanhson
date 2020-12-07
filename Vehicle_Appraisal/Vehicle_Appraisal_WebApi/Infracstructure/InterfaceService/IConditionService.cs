using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IConditionService : IService<ConditionVM>
    {
        Task<string> UploadImage(IFormFile file);
    }
}
