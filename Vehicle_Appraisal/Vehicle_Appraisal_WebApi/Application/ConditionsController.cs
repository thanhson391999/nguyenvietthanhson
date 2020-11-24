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
    [Authorize(Roles = "Admin,Users")]
    public class ConditionsController : ControllerBase
    {
        private readonly IConditionService _ConditionService;
        public ConditionsController(IConditionService ConditionService)
        {
            _ConditionService = ConditionService;
        }
        [HttpGet]
        public async Task<List<ConditionVM>> GetAll()
        {
            return await _ConditionService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ConditionVM> GetById(int id)
        {
            return await _ConditionService.GetById(id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ConditionService.Delete(id);
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
        public async Task<IActionResult> Insert(ConditionVM ConditionVM)
        {
            var result = await _ConditionService.Insert(ConditionVM);
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
        public async Task<IActionResult> Update(ConditionVM ConditionVM, int id)
        {
            var result = await _ConditionService.Update(ConditionVM, id);
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
        [HttpPost("image")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage([FromForm]IFormFile file)
        {
            if (file == null)
            {
                return BadRequest("Error 400");
            }
            string image = await _ConditionService.UploadImage(file);
            return Ok(image);
        }
    }
}

