using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Models
{
    public class DashBoardModelMVC
    {
        public List<CustomerVM> ListCustomerVM { get; set; }
        public List<AppUserVM> ListAppuserVM { get; set; }
        public List<VehicleVM> ListVehicleVM { get; set; }
    }
}
