using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class EmailService : IEmailService
    {
        private readonly DbContextDTO _dbContextDTO;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private DbSet<AppUserDTO> dbset;
        public EmailService(DbContextDTO dbContextDTO, IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _configuration = configuration;
            _mapper = mapper;
            _userService = userService;
            _dbContextDTO = dbContextDTO;
            dbset = dbContextDTO.Set<AppUserDTO>();
        }

        public async Task<bool> ConfirmEmail(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var readtoken = handler.ReadJwtToken(token);
            var email = readtoken.Claims.Where(x => x.Type.Equals("Email")).FirstOrDefault().ToString().Split(' ').ElementAt(1);
            if (email == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var userDTO = await dbset.Where(x => x.Email.Equals(email)).AsNoTracking().SingleOrDefaultAsync();
            userDTO.ConfirmEmail = true;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ResetPassword(PasswordVM passwordVM)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(passwordVM.Token);
            var email = token.Claims.Where(x => x.Type.Equals("Email")).FirstOrDefault().ToString().Split(' ').ElementAt(1);
            if (passwordVM.NewPassword != passwordVM.ConfirmNewPassword || passwordVM.NewPassword == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var passwordHash = new PasswordHash();
            var password = passwordHash.HashPassword(passwordVM.NewPassword);
            var userVM = await _userService.GetUser(email);
            var userDTO = _mapper.Map<AppUserDTO>(userVM);
            userDTO.PassWord = password;
            userDTO.UpdateAt = DateTime.Now;
            dbset.Update(userDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SendEmail(string email, string htmlContent, string subject)
        {
            if (email == null || htmlContent == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var apikey = _configuration.GetSection("SendGridApiKey").Value;
            var client = new SendGridClient(apikey);
            var from = new EmailAddress("son.nguyen@siliconstack.com.au", "SendGridEmail");
            var to = new EmailAddress(email, "Thanhson3121999");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlContent, htmlContent);
            await client.SendEmailAsync(msg);
            return true;
        }
    }
}
