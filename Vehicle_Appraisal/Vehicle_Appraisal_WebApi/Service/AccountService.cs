using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
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

        public async Task<ApiResultVM<string>> Login(LoginVM loginVM)
        {
            var userVM = await _userService.GetUser(loginVM.UserName);
            if (userVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("User doesn't exist");
            }
            var userDTO = await dbset.Where(x => x.Id.Equals(userVM.Id)).AsNoTracking().SingleOrDefaultAsync();
            var passwordHash = new PasswordHash();
            var password = passwordHash.HashPassword(loginVM.Password);
            if (password == userDTO.PassWord)
            {
                if (userDTO.ConfirmEmail == false)
                {
                    var subject = "Email For Confirm Password";
                    var tokenemail = GenarateTokenEmail(userDTO.Email);
                    string url = $"{ _configuration["AppUrl"]}/api/emails/email-confirm/?tokenemail={tokenemail}";
                    var htmlContent = $"Please confirm your email by click here <a href='{url}'> Link</a>";
                    await _emailService.SendEmail(userDTO.Email, htmlContent, subject);
                }
                string token = GenarateToken(userVM);
                return new ApiSuccessResultVM<string>(token);
            }
            return new ApiErrorResultVM<string>("Password is incorrect");
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

        public async Task<ApiResultVM<string>> Register(RegisterVM registerVM)
        {
            var email = await _userService.GetUser(registerVM.Email);
            var userName = await _userService.GetUser(registerVM.UserName);
            var fullName = await dbset.Where(x => x.FullName.Equals(registerVM.FullName)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefaultAsync();
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
            var passwordHash = new PasswordHash();
            var userDTO = _mapper.Map<AppUserDTO>(registerVM);
            userDTO.PassWord = passwordHash.HashPassword(registerVM.Password);
            userDTO.AppUserRolesId = 2;
            userDTO.CreateAt = DateTime.Now;
            userDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            var tokenEmail = GenarateTokenEmail(userDTO.Email);
            string url = $"{ _configuration["AppUrl"]}/api/emails/email-confirm/?tokenemail={tokenEmail}";
            var subject = "Email For Confirm Password";
            var htmlContent = $"Please confirm your email by click here <a href='{url}'> Link</a>";
            await _emailService.SendEmail(userDTO.Email, htmlContent, subject);
            return new ApiSuccessResultVM<string>("Register Success");
        }

        public async Task<ApiResultVM<string>> ForgotPassword(string email)
        {
            if (email == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("email is empty");
            }
            var token = GenarateTokenEmail(email);
            var subject = "Email For Reset Password";
            string url = $"{ _configuration["AppUrl"]}/password-reset/?token={token}";
            var htmlContent = $"Please reset your password by click here <a href='{url}'> Link</a>";
            await _emailService.SendEmail(email, htmlContent, subject);
            return new ApiSuccessResultVM<string>("Email to reset password has sent to you, check your email now !");
        }
    }
}