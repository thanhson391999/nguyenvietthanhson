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
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRoleService _UserRoleService;

        public UserRolesController(IUserRoleService UserRoleService)
        {
            _UserRoleService = UserRoleService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<AppUserRoleVM>> GetAll()
        {
            return await _UserRoleService.GetAll();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserRoleVM> GetById(int id)
        {
            return await _UserRoleService.GetById(id);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _UserRoleService.Delete(id);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Delete Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Delete Fail !",
                is_erro = true,
            });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(AppUserRoleVM UserRoleVM)
        {
            var result = await _UserRoleService.Insert(UserRoleVM);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Insert Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Insert Fail !",
                is_erro = true,
            });
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(AppUserRoleVM UserRoleVM, int id)
        {
            var result = await _UserRoleService.Update(UserRoleVM, id);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Update Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Update Fail !",
                is_erro = true,
            });
        }
    }
}
