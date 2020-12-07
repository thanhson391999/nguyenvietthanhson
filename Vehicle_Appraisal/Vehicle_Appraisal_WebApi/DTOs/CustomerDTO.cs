using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    [Table("Customers")]
    public class CustomerDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool isDelete { get; set; } = false;

        public virtual ICollection<VehicleDTO> VehicleDTOs { get; set; }
    }
}
