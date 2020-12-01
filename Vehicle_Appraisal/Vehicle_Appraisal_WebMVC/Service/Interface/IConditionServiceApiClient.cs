using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IConditionServiceApiClient
    {
        Task<string> UploadImage(IFormFile file, string token);
        Task<ApiResultVM<string>> Insert(ConditionVM conditionVM, string token);
        Task<ApiResultVM<string>> Delete(int id, string token);
        Task<ApiResultVM<string>> Update(ConditionVM conditionVM, string token);
    }
}
