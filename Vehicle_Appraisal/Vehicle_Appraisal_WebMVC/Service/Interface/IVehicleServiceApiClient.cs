using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IVehicleServiceApiClient : IServiceApiClient<VehicleModelMVC>
    {
        Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id, string token);
        Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(string token, int id, PaginationVM paginationVM);
        Task<PageResultVM<VehicleVM>> GetAllPaging(string token, PaginationSearchVM paginationSearchVM);
        Task<List<VehicleVM>> GetAllNotBuy(string token);
        Task<List<VehicleModelMVC>> GetAllVehicleBought(string token);
        Task<PageResultVM<VehicleModelMVC>> GetAllVehicleBoughtPaging(string token, DateTime fromDate, DateTime toDate, PaginationVM paginationVM);
        Task<List<VehicleModelMVC>> Search(string token, string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId);

        Task<ApiResultVM<string>> BuyVehicle(int id, string token);

    }
}
