using eShopSolution.Application.System.Users;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // POST: api/users/login
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var apiResult = await _userService.Login(request);
            if (apiResult.IsSuccessed == true)
                return Ok(apiResult);
            else
                return BadRequest(apiResult);
        }

        // POST: api/users
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var apiResult = await _userService.Register(request);
            if (apiResult.IsSuccessed == true)
                return Ok(apiResult);
            else
                return BadRequest(apiResult);
        }

        // GET: api/users/paging?PageIndex=1&PageSize=10&Keyword=
        [HttpGet("paging")]
        public async Task<PagedResult<UserViewModel>> GetUsersPaging([FromQuery] GetUserPagingRequest request)
        {
            var pagedResult = await _userService.GetUsersPaging(request);
            return pagedResult;
        }

        // PUT: api/users/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UserUpdateRequest request)
        {
            var apiResult = await _userService.Update(id, request);
            if (apiResult.IsSuccessed == true)
                return Ok(apiResult);
            else
                return BadRequest(apiResult);
        }

        // GET: api/users/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var apiResult = await _userService.GetById(id);
            if (apiResult.IsSuccessed == true)
                return Ok(apiResult);
            else
                return BadRequest(apiResult);
        }

        // DELETE: api/users/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var apiResult = await _userService.Delete(id);
            if (apiResult.IsSuccessed == true)
                return Ok(apiResult);
            else
                return BadRequest(apiResult);
        }
    }
}