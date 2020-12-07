using Microsoft.AspNetCore.Http;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class ConditionVM : BaseVM
    {
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string Note { get; set; }
        public int VehicleId { get; set; }
        public IFormFile file { get; set; }

    }
}
