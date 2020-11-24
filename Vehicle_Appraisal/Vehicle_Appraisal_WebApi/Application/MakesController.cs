using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.DALs;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class MakesController : ControllerBase
    {
        private readonly IMakeService _makeService;
        public MakesController(IMakeService makeService)
        {
            _makeService = makeService;
        }
        [HttpGet]
        public async Task<List<MakeVM>> GetAll()
        {
            return await _makeService.GetAll();
        }
        [HttpGet("not-delete")]
        public async Task<List<MakeVM>> GetAllNotDelete()
        {
            return await _makeService.GetAllNotDelete();
        }
        [HttpGet("{id}")]
        public async Task<MakeVM> GetById(int id)
        {
            return await _makeService.GetById(id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _makeService.Delete(id);
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
        public async Task<IActionResult> Insert(MakeVM makeVM)
        {
            var result = await _makeService.Insert(makeVM);
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
        public async Task<IActionResult> Update(MakeVM makeVM, int id)
        {
            var result = await _makeService.Update(makeVM, id);
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
