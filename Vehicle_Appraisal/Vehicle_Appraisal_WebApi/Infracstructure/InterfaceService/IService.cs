using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<ApiResultVM<string>> Insert(T entity);
        Task<ApiResultVM<string>> Update(T entity,int id);
        Task<ApiResultVM<string>> Delete(int id);
    }
}
