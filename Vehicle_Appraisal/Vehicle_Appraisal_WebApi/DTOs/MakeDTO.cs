﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("Makes")]
    public class MakeDTO : BaseDTO
    {
        public string Name { get; set; }
        public bool isDelete { get; set; } = false;

        public virtual ICollection<VehicleDTO> VehicleDTOs { get; set; }
    }
}