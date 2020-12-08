using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IServiceApiClient<T>
    {
        Task<List<T>> GetAll(string token);
        Task<T> GetById(int Id, string token);
        Task<ApiResultVM<string>> Insert(T entity, string token);
        Task<ApiResultVM<string>> Delete(int id, string token);
        Task<ApiResultVM<string>> Update(T entity, string token);
    }
}
