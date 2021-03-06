﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class UserService : IUserService
    {
        private readonly DbContextDTO _dbContextDTO;
        private DbSet<AppUserDTO> dbset;
        private IMapper _mapper;
        public UserService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<AppUserDTO>();
        }

        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var userVM = await GetById(id);
            if (userVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Users doesn't exist");
            }
            var checkConstraint = await _dbContextDTO.Set<VehicleDTO>().Where(x => x.AppUserId.Equals(id)).Where(x => x.isBought == false).AsNoTracking().FirstOrDefaultAsync();
            if (checkConstraint != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Can't delete because users is existing in vehicle");
            }
            var userDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            userDTO.isDelete = true;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<AppUserVM>> GetAll()
        {
            var userDTO = await dbset.Where(x => x.isDelete == false).ToListAsync();
            var userVM = _mapper.Map<List<AppUserVM>>(userDTO);
            return userVM;
        }

        public async Task<AppUserVM> GetById(int id)
        {
            var userDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            var userVM = _mapper.Map<AppUserVM>(userDTO);
            return userVM;
        }

        public async Task<ApiResultVM<string>> Update(AppUserVM UserVM, int id)
        {
            var checkValue = dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefault();
            if (checkValue == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Users doesn't exist");
            }
            var userName = await dbset.Where(x => x.Id != id).Where(x => x.UserName.Equals(UserVM.UserName)).AsNoTracking().FirstOrDefaultAsync();
            var fullName = await dbset.Where(x => x.Id != id).Where(x => x.FullName.Equals(UserVM.FullName)).AsNoTracking().FirstOrDefaultAsync();
            var email = await dbset.Where(x => x.Id != id).Where(x => x.Email.Equals(UserVM.Email)).AsNoTracking().FirstOrDefaultAsync();
            if (userName != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("UserName is exist");
            }
            if (email != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Email is exist");
            }
            if (fullName != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("FullName is exist");
            }
            var userDTO = _mapper.Map<AppUserDTO>(UserVM);
            userDTO.Id = id;
            userDTO.PassWord = checkValue.PassWord;
            userDTO.CreateAt = checkValue.CreateAt;
            userDTO.ConfirmEmail = checkValue.ConfirmEmail;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }

        public async Task<AppUserVM> GetUser(string emailorusername)
        {
            var userDTO = await dbset.Where(x => x.Email.Equals(emailorusername) || x.UserName.Equals(emailorusername)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefaultAsync();
            var userVM = _mapper.Map<AppUserVM>(userDTO);
            return userVM;
        }

        public async Task<ApiResultVM<string>> ChangePassword(PasswordVM passwordVM)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(passwordVM.Token);
            var username = token.Claims.Where(x => x.Type.Equals("UserName")).FirstOrDefault().ToString().Split(' ').ElementAt(1);
            var passwordHash = new PasswordHash();
            var password = passwordHash.HashPassword(passwordVM.NewPassword);
            var userDTO = await dbset.Where(x => x.UserName.Equals(username)).AsNoTracking().SingleOrDefaultAsync();
            userDTO.PassWord = password;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Password has changed");
        }

        public async Task<PageResultVM<AppUserVM>> GetAllPaging(PaginationVM paginationVM)
        {
            var listUserDTO = await dbset.Where(x => x.isDelete == false).Where(x => x.AppUserRolesId == 2).ToListAsync();
            var listUserVM = _mapper.Map<List<AppUserVM>>(listUserDTO).OrderByDescending(x=>x.CreateAt.Date);
            var listUserVMPagination = listUserVM.Skip((paginationVM.PageIndex - 1) * paginationVM.PageSize).Take(paginationVM.PageSize).ToList();
            return new PageResultVM<AppUserVM>
            {
                Items = listUserVMPagination,
                PageIndex = paginationVM.PageIndex,
                TotalRecord = listUserVM.Count()
            };
        }

        public async Task<List<AppUserVM>> GetAllNotDelete()
        {
            var listUserDTO = await dbset.ToListAsync();
            var listUserVM = _mapper.Map<List<AppUserVM>>(listUserDTO);
            return listUserVM;
        }
    }
}
