using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("VehicleAppraisals")]
    public class VehicleAppraisalDTO : BaseDTO
    {
        public string AppraisalValue { get; set; }

        [ForeignKey("VehicleDTO")]
        public int VehicleId { get; set; }

        public virtual VehicleDTO VehicleDTO { get; set; }


    }
}
