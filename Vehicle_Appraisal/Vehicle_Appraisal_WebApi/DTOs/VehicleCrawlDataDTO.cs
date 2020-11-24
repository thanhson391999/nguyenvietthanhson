using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
