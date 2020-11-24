using AutoMapper;
using com.sun.org.apache.bcel.@internal.classfile;
using com.sun.org.apache.bcel.@internal.generic;
using java.net;
using javax.swing.text;
using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class AccountService : IAccountService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly IConfiguration _configuration;
        private readonly IUserRoleService _userRoleService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private DbSet<AppUserDTO> dbset;
        public AccountService(DbContextDTO dbContextDTO, IEmailService emailService, IMapper mapper, IUserRoleService userRoleService, IConfiguration configuration, IUserService userService)
        {
            _emailService = emailService;
            _mapper = mapper;
            _userService = userService;
            _configuration = configuration;
            _userRoleService = userRoleService;
            _dbContextDTO = dbContextDTO;
            dbset = dbContextDTO.Set<AppUserDTO>();
        }
        public async Task<string> Login(LoginVM loginVM)
        {
            string token = null;
            var userVM = await _userService.GetUser(loginVM.UserName);
            var userDTO = await dbset.Where(x => x.Id.Equals(userVM.Id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            if (loginVM.UserName == null || loginVM.Password == null || userVM == null)
            {
                _dbContextDTO.Dispose();
                return token;
            }
            var passwordHash = new PasswordHash();
            var password = passwordHash.HashPassword(loginVM.Password);
            if (password == userDTO.PassWord)
            {
                if (userDTO.ConfirmEmail == false)
                {
                    var subject = "Email For Confirm Password";
                    var tokenemail = GenarateTokenEmail(userDTO.Email);
                    string url = $"{ _configuration["AppUrl"]}/api/emails/confirmemail?tokenemail={tokenemail}";
                    var htmlContent = $"Please confirm your email by click here <a href='{url}'> Link</a>";
                    await _emailService.SendEmail(userDTO.Email, htmlContent, subject);
                }
                return token = GenarateToken(userVM);
            }
            return token;
        }
        private string GenarateToken(AppUserVM UserVM)
        {
            var issuer = _configuration["JWT:Issuer"];
            var audience = _configuration["JWT:Audience"];
            var secretkey = new SymmetricSecurityKey(UTF8Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
            var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>();
            claims.Add(new Claim("Role", _userRoleService.GetById(UserVM.AppUserRolesId).Result.Name));
            claims.Add(new Claim("AppUserRoleId", _userRoleService.GetById(UserVM.AppUserRolesId).Result.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Role, _userRoleService.GetById(UserVM.AppUserRolesId).Result.Name));
            claims.Add(new Claim("UserName", UserVM.UserName));
            claims.Add(new Claim("ConfirmEmail", UserVM.ConfirmEmail));
            claims.Add(new Claim("Email", UserVM.Email));
            claims.Add(new Claim("Id", UserVM.Id.ToString()));
            claims.Add(new Claim("FullName", UserVM.FullName));
            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private string GenarateTokenEmail(string email)
        {
            var issuer = _configuration["JWT:Issuer"];
            var audience = _configuration["JWT:Audience"];
            var secretkey = new SymmetricSecurityKey(UTF8Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
            var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>();
            claims.Add(new Claim("Email", email));
            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterVM registerVM)
        {
            var userEmail = await _userService.GetUser(registerVM.Email);
            var userUserName = await _userService.GetUser(registerVM.UserName);
            if (registerVM.Password == null ||
                registerVM.Email == null ||
                registerVM.FullName == null ||
                registerVM.UserName == null ||
                registerVM.Password != registerVM.ConfirmPassword ||
                userEmail != null ||
                userUserName != null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var passwordHash = new PasswordHash();
            var userDTO = _mapper.Map<AppUserDTO>(registerVM);
            userDTO.PassWord = passwordHash.HashPassword(registerVM.Password);
            userDTO.AppUserRolesId = 2;
            userDTO.CreateAt = DateTime.Now;
            userDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            var tokenEmail = GenarateTokenEmail(userDTO.Email);
            string url = $"{ _configuration["AppUrl"]}/api/emails/confirmemail?tokenemail={tokenEmail}";
            var subject = "Email For Confirm Password";
            var htmlContent = $"Please confirm your email by click here <a href='{url}'> Link</a>";
            await _emailService.SendEmail(userDTO.Email, htmlContent, subject);
            return true;
        }

        public async Task<bool> ForgotPassword(string email)
        {
            if (email == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var token = GenarateTokenEmail(email);
            var subject = "Email For Reset Password";
            string url = $"{ _configuration["AppUrl"]}/resetpassword?token={token}";
            var htmlContent = $"Please reset your password by click here <a href='{url}'> Link</a>";
            await _emailService.SendEmail(email, htmlContent,subject);
            return true;
        }
    }
}