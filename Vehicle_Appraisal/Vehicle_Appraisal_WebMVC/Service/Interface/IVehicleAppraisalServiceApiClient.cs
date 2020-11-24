using System;
using System.Collections.Generic;
using System.Linq;
using Vehicle_Appraisal_WebApi.ViewModels;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IVehicleAppraisalServiceApiClient
    {
        Task<bool> Insert(VehicleAppraisalVM vehicleAppraisalVM, string token);
        Task<bool> Delete(int id, string token);
        Task<bool> Update(VehicleAppraisalVM vehicleAppraisalVM, string token);
    }
}
