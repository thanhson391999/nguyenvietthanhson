using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("AppUserRoles")]
    public class AppUserRoleDTO : BaseDTO
    {
        public string Name { get; set; }
        
        public virtual ICollection<AppUserDTO> AppUserDTOs { get; set; }
    }
}
