using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IServiceApiClient<T>
    {
        Task<List<T>> GetAll(string token);
        Task<T> GetById(int Id, string token);
        Task<bool> Insert(T entity, string token);
        Task<bool> Delete(int id, string token);
        Task<bool> Update(T entity, string token);
    }
}
