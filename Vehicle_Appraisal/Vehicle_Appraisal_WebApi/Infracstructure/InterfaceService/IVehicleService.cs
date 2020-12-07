using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService
{
    public interface IVehicleService : IService<VehicleVM>, IPaginationService<VehicleVM>
    {
        Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(int id, PaginationVM paginationVM);
        Task<PageResultVM<VehicleVM>> GetAllVehicleBoughtPaging(DateTime fromDate, DateTime toDate, PaginationVM paginationVM);
        Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id);
        Task<List<VehicleVM>> GetAllVehicleBought();
        Task<List<VehicleVM>> GetAllNotBuy();
        Task<List<VehicleVM>> Search(string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId);

        Task<ApiResultVM<string>> BuyVehicle(int id);

    }
}
