using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("VehicleCrawlDatas")]
    public class VehicleCrawlDataDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Value { get; set; }
    }
}
