using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class RegisterVM : AppUserVM
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
