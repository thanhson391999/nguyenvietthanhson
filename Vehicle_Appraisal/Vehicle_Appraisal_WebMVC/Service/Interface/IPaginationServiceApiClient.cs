using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IPaginationServiceApiClient<T>
    {
        Task<PageResultVM<T>> GetAllPaging(string token, PaginationVM paginationVM);
    }
}
