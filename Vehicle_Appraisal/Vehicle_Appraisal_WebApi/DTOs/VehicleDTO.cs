using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("Vehicles")]
    public class VehicleDTO : BaseDTO
    {
        [ForeignKey("CustomerDTO")]
        public int CustomerId { get; set; }
        [ForeignKey("MakeDTO")]
        public int MakeId { get; set; }
        [ForeignKey("ModelDTO")]
        public int ModelId { get; set; }
        [ForeignKey("AppUserDTO")]
        public int AppUserId { get; set; }
        public string Odometer { get; set; }
        public string VIN { get; set; }
        public string Engine { get; set; }
        public bool isDelete { get; set; } = false;
        
        public virtual AppUserDTO AppUserDTO { get; set; }
        public virtual CustomerDTO CustomerDTO { get; set; }
        public virtual MakeDTO MakeDTO { get; set; }
        public virtual ModelDTO ModelDTO { get; set; }
        
        public virtual ICollection<VehicleAppraisalDTO> VehicleAppraisalDTOs { get; set; }
        public virtual ICollection<ConditionDTO> ConditionDTOs { get; set; }
    }
}
