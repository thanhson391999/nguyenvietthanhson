using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IVehicleServiceApiClient : IServiceApiClient<VehicleModelMVC>
    {
        Task<List<ConditionVM>> GetAllConditionById(int id, string token);
        Task<List<VehicleAppraisalVM>> GetAllAppraisalValueById(int id, string token);
        Task<List<VehicleModelMVC>> Search(string token, string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId);
    }
}
