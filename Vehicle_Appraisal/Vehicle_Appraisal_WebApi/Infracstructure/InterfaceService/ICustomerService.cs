using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface ICustomerService : IService<CustomerVM>
    {
        Task<List<CustomerVM>> GetAllNotDelete();
        Task<PageResultVM<CustomerVM>> GetAllPaging(PaginationSearchVM paginationSearchVM);
    }
}
