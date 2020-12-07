using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IPaginationService<T>
    {
        Task<PageResultVM<T>> GetAllPaging(PaginationVM paginationVM);
    }
}
