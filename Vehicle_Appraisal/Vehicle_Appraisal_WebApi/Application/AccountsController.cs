using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            string access_token = await _accountService.Login(loginVM);
            if (access_token == null)
            {
                return BadRequest(access_token);
            }
            else
            {
                return Ok(access_token);
            }
        }
        [HttpPost("register")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            var result = await _accountService.Register(registerVM);
            if (result)
            {
                return Ok(new
                {
                    message = "Register Success !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "Register Fail !",
                    is_erro = true
                });
            }
        }
        [HttpGet("forgotpassword")]
        public async Task<IActionResult> ResetPassword(string email)
        {
            var result = await _accountService.ForgotPassword(email);
            if (result)
            {
                return Ok(new
                {
                    message = "Email to reset password has send to you, check it !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "something wrong, we can't send email to reset password for you !",
                    is_erro = true
                });
            }
        }
    }
}
