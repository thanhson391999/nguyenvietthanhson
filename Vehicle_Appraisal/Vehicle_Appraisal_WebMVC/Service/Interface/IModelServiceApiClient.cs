using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IModelServiceApiClient : IServiceApiClient<ModelVM>
    {
        Task<List<ModelVM>> GetAllNotDelete(string token);
    }
}
