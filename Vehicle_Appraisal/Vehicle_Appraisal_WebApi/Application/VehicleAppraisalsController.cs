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
    public class VehicleAppraisalsController : ControllerBase
    {
        private readonly IVehicleAppraisalService _VehicleAppraisalService;
        public VehicleAppraisalsController(IVehicleAppraisalService VehicleAppraisalService)
        {
            _VehicleAppraisalService = VehicleAppraisalService;
        }
        [HttpGet]
        public async Task<List<VehicleAppraisalVM>> GetAll()
        {
            return await _VehicleAppraisalService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<VehicleAppraisalVM> GetById(int id)
        {
            return await _VehicleAppraisalService.GetById(id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _VehicleAppraisalService.Delete(id);
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
        public async Task<IActionResult> Insert(VehicleAppraisalVM VehicleAppraisalVM)
        {
            var result = await _VehicleAppraisalService.Insert(VehicleAppraisalVM);
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
        public async Task<IActionResult> Update(VehicleAppraisalVM VehicleAppraisalVM, int id)
        {
            var result = await _VehicleAppraisalService.Update(VehicleAppraisalVM, id);
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
