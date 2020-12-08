using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface ICustomerServiceApiClient : IServiceApiClient<CustomerVM>
    {
        Task<List<CustomerVM>> GetAllNotDelete(string token);
        Task<PageResultVM<CustomerVM>> GetAllPaging(string token, PaginationSearchVM paginationSearchVM);
    }
}
