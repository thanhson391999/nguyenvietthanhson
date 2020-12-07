using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
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

        // GET api/conditions
        [HttpGet]
        public async Task<List<ConditionVM>> GetAll()
        {
            return await _ConditionService.GetAll();
        }

        // GET api/conditions/{id}
        [HttpGet("{id}")]
        public async Task<ConditionVM> GetById(int id)
        {
            return await _ConditionService.GetById(id);
        }

        // DELETE api/conditions/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ConditionService.Delete(id);
            return Ok(result);
        }

        // POST api/conditions
        [HttpPost]
        public async Task<IActionResult> Insert(ConditionVM ConditionVM)
        {
            var result = await _ConditionService.Insert(ConditionVM);
            return Ok(result);
        }

        // PUT api/conditions/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ConditionVM ConditionVM, int id)
        {
            var result = await _ConditionService.Update(ConditionVM, id);
            return Ok(result);
        }

        // POST api/conditions/image
        [HttpPost("image")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            if (file == null)
            {
                return BadRequest(new
                {
                    message = "File is empty",
                    is_erro = true
                });
            }
            string image = await _ConditionService.UploadImage(file);
            return Ok(image);
        }
    }
}

