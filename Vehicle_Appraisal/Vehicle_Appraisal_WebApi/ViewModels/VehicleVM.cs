using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class VehicleVM : BaseVM
    {
        public int CustomerId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int AppUserId { get; set; }
        public string Odometer { get; set; }
        public string VIN { get; set; }
        public string Engine { get; set; }
        public bool isBought { get; set; }
    }
}
