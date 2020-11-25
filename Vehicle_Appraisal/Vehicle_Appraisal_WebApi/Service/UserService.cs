using AutoMapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using org.omg.IOP;
using SendGrid.Helpers.Mail;
using sun.security.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class UserService : IUserService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly IConfiguration _configuration;
        private readonly IUserRoleService _userRoleService;
        private DbSet<AppUserDTO> dbset;
        private IMapper _mapper;
        public UserService(DbContextDTO dbContextDTO, IMapper mapper, IUserRoleService userRoleService, IConfiguration configuration)
        {
            _configuration = configuration;
            _userRoleService = userRoleService;
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<AppUserDTO>();
        }
        public async Task<bool> Delete(int id)
        {
            var userVM = await GetById(id);
            if (userVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var VehicleDTO = await _dbContextDTO.Set<VehicleDTO>().Where(x => x.AppUserId.Equals(id)).Where(x => x.isBought == false).AsNoTracking().FirstOrDefaultAsync();
            if (VehicleDTO != null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var userDTO = await dbset.Where(x => x.Id.Equals(id)).AsNoTracking().SingleOrDefaultAsync();
            userDTO.isDelete = true;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
             await _dbContextDTO.SaveChangesAsync();
            return true;
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

        public async Task<bool> Update(AppUserVM UserVM, int id)
        {
            var checkValue = dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefault();
            if (checkValue == null ||
                UserVM.Email == null ||
                UserVM.FullName == null ||
                UserVM.UserName == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var userDTO = _mapper.Map<AppUserDTO>(UserVM);
            userDTO.Id = id;
            userDTO.PassWord = checkValue.PassWord;
            userDTO.CreateAt = checkValue.CreateAt;
            userDTO.ConfirmEmail = checkValue.ConfirmEmail;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<AppUserVM> GetUser(string emailorusername)
        {
            var userDTO = await dbset.Where(x => x.Email.Equals(emailorusername) || x.UserName.Equals(emailorusername)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefaultAsync();
            var userVM = _mapper.Map<AppUserVM>(userDTO);
            return userVM;
        }

        public async Task<bool> ChangePassword(PasswordVM passwordVM)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(passwordVM.Token);
            var username = token.Claims.Where(x => x.Type.Equals("UserName")).FirstOrDefault().ToString().Split(' ').ElementAt(1);
            if (passwordVM.NewPassword != passwordVM.ConfirmNewPassword || passwordVM.NewPassword == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var passwordHash = new PasswordHash();
            var password = passwordHash.HashPassword(passwordVM.NewPassword);
            var userDTO = dbset.Where(x => x.UserName.Equals(username)).AsNoTracking().SingleOrDefault();
            userDTO.PassWord = password;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }
    }
}
