using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class VehicleAppraisalVM : BaseVM
    {
        public string AppraisalValue { get; set; }
        public int VehicleId { get; set; }

    }
}
