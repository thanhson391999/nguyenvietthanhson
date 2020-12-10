using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IVehicleService : IService<VehicleVM>
    {
        Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(int id, PaginationVM paginationVM);
        Task<PageResultVM<VehicleVM>> GetAllVehicleBoughtPaging(DateTime fromDate, DateTime toDate, PaginationVM paginationVM);
        Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id);
        Task<PageResultVM<VehicleVM>> GetAllPaging(PaginationSearchVM paginationSearchVM);
        Task<List<VehicleVM>> GetAllVehicleBought();
        Task<List<VehicleVM>> GetAllNotBuy();
        Task<ApiResultVM<string>> BuyVehicle(int id);

    }
}
