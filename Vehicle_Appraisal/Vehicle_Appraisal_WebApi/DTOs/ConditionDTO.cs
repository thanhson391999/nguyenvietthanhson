using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("Conditions")]
    public class ConditionDTO : BaseDTO
    {
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string Note { get; set; }

        [ForeignKey("VehicleDTO")]
        public int VehicleId { get; set; }

        public virtual VehicleDTO VehicleDTO { get; set; }
    }
}
