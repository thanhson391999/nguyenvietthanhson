using System.Collections.Generic;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Models
{
    public class VehicleModelMVC : VehicleVM
    {
        public List<CustomerVM> CustomerVMs { get; set; }
        public List<MakeVM> MakeVMs { get; set; }
        public List<ModelVM> ModelVMs { get; set; }
        public List<AppUserVM> AppUserVMs { get; set; }
    }
}
