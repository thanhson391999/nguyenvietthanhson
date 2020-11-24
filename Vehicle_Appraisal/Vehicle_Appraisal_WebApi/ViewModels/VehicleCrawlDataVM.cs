using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class VehicleCrawlDataVM : BaseVM
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Value { get; set; }
    }
}
