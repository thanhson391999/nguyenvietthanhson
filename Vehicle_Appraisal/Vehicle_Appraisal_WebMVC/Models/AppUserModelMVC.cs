using System.Collections.Generic;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Models
{
    public class AppUserModelMVC
    {
        public AppUserVM appUserVM { get; set; }
        public AppUserRoleVM appUserRoleVM { get; set; }
        public List<AppUserRoleVM> ListAppUserRoleVM { get; set; }
    }
}
