﻿using System;
using System.Collections.Generic;
using System.Linq;
using Vehicle_Appraisal_WebApi.ViewModels;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface IVehicleAppraisalServiceApiClient
    {
        Task<List<VehicleAppraisalVM>> GetAll(string token);
        Task<ApiResultVM<string>> Insert(VehicleAppraisalVM vehicleAppraisalVM, string token);
        Task<ApiResultVM<string>> Delete(int id, string token);
        Task<ApiResultVM<string>> Update(VehicleAppraisalVM vehicleAppraisalVM, string token);
    }
}
