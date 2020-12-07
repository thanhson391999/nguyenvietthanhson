using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IModelService : IService<ModelVM>, IPaginationService<ModelVM>
    {
        Task<List<ModelVM>> GetAllNotDelete();
    }
}
