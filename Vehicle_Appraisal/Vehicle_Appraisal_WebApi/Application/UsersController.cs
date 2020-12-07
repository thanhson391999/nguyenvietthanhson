using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
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

        // GET api/users
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<AppUserVM>> GetAll()
        {
            return await _userService.GetAll();
        }

        // GET api/users/paging
        [HttpGet("paging")]
        [Authorize(Roles = "Admin")]
        public async Task<PageResultVM<AppUserVM>> GetAllPaging([FromQuery] PaginationVM paginationVM)
        {
            return await _userService.GetAllPaging(paginationVM);
        }

        // GET api/users/not-delete
        [HttpGet("not-delete")]
        [Authorize(Roles = "Admin")]
        public async Task<List<AppUserVM>> GetAllNotDelete()
        {
            return await _userService.GetAllNotDelete();
        }

        // GET api/users/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserVM> GetById(int id)
        {
            return await _userService.GetById(id);
        }

        // GET api/users/info
        [HttpGet("info")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserVM> GetUser(string emailorusername)
        {
            return await _userService.GetUser(emailorusername);
        }

        // DELETE api/users/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userService.Delete(id);
            return Ok(result);
        }

        // PUT api/users/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> Update(AppUserVM userVM, int id)
        {
            var result = await _userService.Update(userVM, id);
            return Ok(result);
        }

        // PUT api/users/password
        [HttpPut("Password")]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> ChangePassword(PasswordVM passwordVM)
        {
            passwordVM.Token = HttpContext.Request.Headers["Authorization"].FirstOrDefault().Split(' ').ElementAt(1);
            var result = await _userService.ChangePassword(passwordVM);
            return Ok(result);
        }
    }
}
