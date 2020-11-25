using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface IVehicleService : IService<VehicleVM>
    {
        Task<bool> BuyVehicle(int id);
        Task<List<VehicleVM>> Search(string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId);
        Task<List<ConditionVM>> GetAllConditionById(int id);
        Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id);
        Task<List<VehicleVM>> GetAllNotBuy();
        Task<List<VehicleVM>> SearchDate(DateTime fromDate, DateTime toDate);
    }
}
