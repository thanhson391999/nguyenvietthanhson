using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Insert(T entity);
        Task<bool> Update(T entity,int id);
        Task<bool> Delete(int id);
    }
}
