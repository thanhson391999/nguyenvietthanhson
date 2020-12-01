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

        // POST api/accounts/login
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var result = await _accountService.Login(loginVM);
            return Ok(result);
        }

        // POST api/accounts/register
        [HttpPost("register")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            var result = await _accountService.Register(registerVM);
            return Ok(result);
        }

        // GET api/accounts/forgotpassword
        [HttpGet("forgotpassword")]
        public async Task<IActionResult> ResetPassword(string email)
        {
            var result = await _accountService.ForgotPassword(email);
            return Ok(result);
        }
    }
}
