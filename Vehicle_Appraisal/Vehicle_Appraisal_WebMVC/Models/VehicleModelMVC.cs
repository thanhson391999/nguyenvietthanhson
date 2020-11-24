using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Models
{
    public class VehicleModelMVC
    {
        public VehicleVM vehicleVM { get; set; }
        public CustomerVM customerVM { get; set; }
        public MakeVM makeVM { get; set; }
        public ModelVM modelVM { get; set; }
        public AppUserVM appUserVM { get; set; }
        public List<CustomerVM> ListCustomerVM { get; set; }
        public List<MakeVM> ListMakeVM { get; set; }
        public List<ModelVM> ListModelVM { get; set; }
        public List<AppUserVM> ListAppUserVM { get; set; }
    }
}
