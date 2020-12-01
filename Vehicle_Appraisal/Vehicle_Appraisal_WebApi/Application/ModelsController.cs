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
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _ModelService;

        public ModelsController(IModelService ModelService)
        {
            _ModelService = ModelService;
        }

        // GET api/models
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<ModelVM>> GetAll()
        {
            return await _ModelService.GetAll();
        }

        // GET api/models/not-delete
        [HttpGet("not-delete")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<ModelVM>> GetAllNotDelete()
        {
            return await _ModelService.GetAllNotDelete();
        }

        // GET api/models/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ModelVM> GetById(int id)
        {
            return await _ModelService.GetById(id);
        }

        // DELETE api/models/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ModelService.Delete(id);
            return Ok(result);
        }

        // POST api/models
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(ModelVM ModelVM)
        {
            var result = await _ModelService.Insert(ModelVM);
            return Ok(result);
        }

        // PUT api/models/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(ModelVM ModelVM, int id)
        {
            var result = await _ModelService.Update(ModelVM, id);
            return Ok(result);
        }
    }
}
