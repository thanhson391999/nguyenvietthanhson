using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class UserRoleService : IUserRoleService
    {
        private DbSet<AppUserRoleDTO> dbset;
        private IMapper _mapper;
        public UserRoleService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _mapper = mapper;
            dbset = dbContextDTO.Set<AppUserRoleDTO>();
        }

        public async Task<List<AppUserRoleVM>> GetAll()
        {
            var listUserRoleDTO = await dbset.ToListAsync();
            var listUserRoleVM = _mapper.Map<List<AppUserRoleVM>>(listUserRoleDTO);
            return listUserRoleVM;
        }

        public async Task<AppUserRoleVM> GetById(int id)
        {
            var UserRoleDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            var UserRoleVM = _mapper.Map<AppUserRoleVM>(UserRoleDTO);
            return UserRoleVM;
        }
    }
}
