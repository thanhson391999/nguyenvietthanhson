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
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var token = await _userService.Login(request);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }

        // POST: api/users
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await _userService.Register(request);
            if (result == false)
            {
                return BadRequest();
            }
            return Ok();
        }

        // GET: api/users/paging?PageIndex=1&PageSize=10&Keyword=
        [HttpGet("paging")]
        public async Task<PagedResult<UserViewModel>> GetUsersPaging([FromQuery] GetUserPagingRequest request)
        {
            var pagedResult = await _userService.GetUsersPaging(request);
            return pagedResult;
        }
    }
}