using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.DTOs
{
    public class DbContextDTO : DbContext
    {
        public DbContextDTO(DbContextOptions dbContextDTO) : base(dbContextDTO)
        { }
        public DbSet<MakeDTO> makeDTOs { get; set; }
        public DbSet<ModelDTO> modelDTOs { get; set; }
        public DbSet<ConditionDTO> conditionDTOs { get; set; }
        public DbSet<VehicleDTO> vehicleDTOs { get; set; }
        public DbSet<VehicleAppraisalDTO> vehicleAppraisalDTOs { get; set; }
        public DbSet<CustomerDTO> customerDTOs { get; set; }
        public DbSet<AppUserDTO> appUserDTOs { get; set; }
        public DbSet<AppUserRoleDTO> appUserRolesDTOs { get; set; }
        public DbSet<VehicleCrawlDataDTO> vehicleCrawlDataDTOs { get; set; }

    }
}
