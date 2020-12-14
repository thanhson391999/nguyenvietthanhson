using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.DALs;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakeService _makeService;

        public MakesController(IMakeService makeService)
        {
            _makeService = makeService;
        }

        // GET api/makes
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<MakeVM>> GetAll()
        {
            return await _makeService.GetAll();
        }

        // GET api/makes/paging
        [HttpGet("paging")]
        [Authorize(Roles = "Admin")]
        public async Task<PageResultVM<MakeVM>> GetAllPaging([FromQuery] PaginationVM paginationVM)
        {
            return await _makeService.GetAllPaging(paginationVM);
        }

        // GET api/makes/not-delete
        [HttpGet("not-delete")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<MakeVM>> GetAllNotDelete()
        {
            return await _makeService.GetAllNotDelete();
        }

        // GET api/makes/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<MakeVM> GetById(int id)
        {
            return await _makeService.GetById(id);
        }

        // DELETE api/makes/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _makeService.Delete(id);
            return Ok(result);
        }

        // POST api/makes
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(MakeVM makeVM)
        {
            var result = await _makeService.Insert(makeVM);
            return Ok(result);
        }

        // PUT api/makes/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(MakeVM makeVM, int id)
        {
            var result = await _makeService.Update(makeVM, id);
            return Ok(result);
        }
    }
}
