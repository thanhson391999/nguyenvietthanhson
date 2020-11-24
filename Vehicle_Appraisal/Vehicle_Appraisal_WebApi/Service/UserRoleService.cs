using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class UserRoleService : IUserRoleService
    {
        private readonly DbContextDTO _dbContextDTO;
        private DbSet<AppUserRoleDTO> dbset;
        private IMapper _mapper;
        public UserRoleService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<AppUserRoleDTO>();
        }

        public async Task<bool> Delete(int id)
        {
            var UserRoleVM = await GetById(id);
            if (UserRoleVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var UserRoleDTO = _mapper.Map<AppUserRoleDTO>(UserRoleVM);
            dbset.Remove(UserRoleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
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

        public async Task<bool> Insert(AppUserRoleVM UserRoleVM)
        {
            if (UserRoleVM.Name == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var UserRoleDTO = _mapper.Map<AppUserRoleDTO>(UserRoleVM);
            UserRoleDTO.CreateAt = DateTime.Now;
            UserRoleDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(UserRoleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(AppUserRoleVM UserRoleVM, int id)
        {
            var checkValue = await GetById(id);
            if (checkValue == null || UserRoleVM.Name == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var UserRoleDTO = _mapper.Map<AppUserRoleDTO>(UserRoleVM);
            UserRoleDTO.Id = id;
            UserRoleDTO.UpdateAt = DateTime.Now;
            dbset.Update(UserRoleDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }
    }
}
