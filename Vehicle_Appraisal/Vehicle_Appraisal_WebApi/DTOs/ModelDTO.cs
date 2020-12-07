using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("Models")]
    public class ModelDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public bool isDelete { get; set; } = false;

        public virtual ICollection<VehicleDTO> VehicleDTOs { get; set; }
    }
}
