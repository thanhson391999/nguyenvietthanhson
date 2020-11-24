using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.sun.corba.se.impl.protocol.giopmsgheaders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<List<AppUserVM>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserVM> GetById(int id)
        {
            return await _userService.GetById(id);
        }

        [HttpGet("info")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserVM> GetUser(string emailorusername)
        {
            return await _userService.GetUser(emailorusername);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userService.Delete(id);
            if (result)
            {
                return Ok(new
                {
                    message = "Delete Success !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "Delete Fail !",
                    is_erro = true
                });
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles ="Admin, Users")]
        public async Task<IActionResult> Update(AppUserVM userVM, int id)
        {
            var result = await _userService.Update(userVM, id);
            if (result)
            {
                return Ok(new
                {
                    message = "Update Success !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "Update Fail !",
                    is_erro = true
                });
            }
        }

        [HttpPut("Password")]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> ChangePassword(PasswordVM passwordVM)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault().Split(' ').ElementAt(1);
            passwordVM.Token = token.ToString();
            var result = await _userService.ChangePassword(passwordVM);
            if (result)
            {
                return Ok(new
                {
                    message = "Password has change !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "Password change fail !",
                    is_erro = true
                });
            }
        }
    }
}
