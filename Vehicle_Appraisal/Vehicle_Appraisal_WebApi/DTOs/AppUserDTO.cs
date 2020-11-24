using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("AppUsers")]
    public class AppUserDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public bool ConfirmEmail { get; set; } = false;
        public bool isDelete { get; set; } = false;
        public string FullName { get; set; }

        [ForeignKey("AppUserRolesDTO")]
        public int AppUserRolesId { get; set; }
        public virtual AppUserRoleDTO AppUserRolesDTO { get; set; }

        public virtual ICollection<VehicleDTO> VehicleDTOs { get; set; }
    }
}
