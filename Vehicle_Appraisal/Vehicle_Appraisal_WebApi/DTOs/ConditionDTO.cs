using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
