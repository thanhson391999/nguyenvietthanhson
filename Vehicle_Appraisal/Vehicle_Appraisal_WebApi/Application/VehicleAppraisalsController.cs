using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class VehicleAppraisalsController : ControllerBase
    {
        private readonly IVehicleAppraisalService _VehicleAppraisalService;

        public VehicleAppraisalsController(IVehicleAppraisalService VehicleAppraisalService)
        {
            _VehicleAppraisalService = VehicleAppraisalService;
        }

        // GET api/vehicleappraisals
        [HttpGet]
        public async Task<List<VehicleAppraisalVM>> GetAll()
        {
            return await _VehicleAppraisalService.GetAll();
        }

        // GET api/vehicleappraisals/{id}
        [HttpGet("{id}")]
        public async Task<VehicleAppraisalVM> GetById(int id)
        {
            return await _VehicleAppraisalService.GetById(id);
        }

        // DELETE api/vehicleappraisals/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _VehicleAppraisalService.Delete(id);
            return Ok(result);
        }

        // POST api/vehicleappraisals
        [HttpPost]
        public async Task<IActionResult> Insert(VehicleAppraisalVM VehicleAppraisalVM)
        {
            var result = await _VehicleAppraisalService.Insert(VehicleAppraisalVM);
            return Ok(result);
        }

        // PUT api/vehicleappraisals/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(VehicleAppraisalVM VehicleAppraisalVM, int id)
        {
            var result = await _VehicleAppraisalService.Update(VehicleAppraisalVM, id);
            return Ok(result);
        }
    }
}
