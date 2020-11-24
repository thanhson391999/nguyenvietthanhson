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
    [Authorize(Roles = "Admin")]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _ModelService;

        public ModelsController(IModelService ModelService)
        {
            _ModelService = ModelService;
        }

        [HttpGet]
        public async Task<List<ModelVM>> GetAll()
        {
            return await _ModelService.GetAll();
        }

        [HttpGet("not-delete")]
        public async Task<List<ModelVM>> GetAllNotDelete()
        {
            return await _ModelService.GetAllNotDelete();
        }

        [HttpGet("{id}")]
        public async Task<ModelVM> GetById(int id)
        {
            return await _ModelService.GetById(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ModelService.Delete(id);
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
        public async Task<IActionResult> Insert(ModelVM ModelVM)
        {
            var result = await _ModelService.Insert(ModelVM);
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
        public async Task<IActionResult> Update(ModelVM ModelVM, int id)
        {
            var result = await _ModelService.Update(ModelVM, id);
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
