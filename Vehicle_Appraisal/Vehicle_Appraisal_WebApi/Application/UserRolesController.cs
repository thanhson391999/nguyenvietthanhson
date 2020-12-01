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

        // GET api/userroles
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<AppUserRoleVM>> GetAll()
        {
            return await _UserRoleService.GetAll();
        }

        // GET api/userroles/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<AppUserRoleVM> GetById(int id)
        {
            return await _UserRoleService.GetById(id);
        }
    }
}
