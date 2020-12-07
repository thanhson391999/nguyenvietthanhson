using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("AppUserRoles")]
    public class AppUserRoleDTO : BaseDTO
    {
        public string Name { get; set; }

        public virtual ICollection<AppUserDTO> AppUserDTOs { get; set; }
    }
}
