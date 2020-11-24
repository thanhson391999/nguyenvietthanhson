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
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _VehicleService;

        public VehiclesController(IVehicleService VehicleService)
        {
            _VehicleService = VehicleService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<VehicleVM>> GetAll()
        {
            return await _VehicleService.GetAll();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<VehicleVM> GetById(int id)
        {
            return await _VehicleService.GetById(id);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _VehicleService.Delete(id);
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
        public async Task<IActionResult> Insert(VehicleVM VehicleVM)
        {
            var result = await _VehicleService.Insert(VehicleVM);
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
        public async Task<IActionResult> Update(VehicleVM VehicleVM, int id)
        {
            var result = await _VehicleService.Update(VehicleVM, id);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Update Success !",
                    is_erro = false
                });
            }
            return BadRequest(new
            {
                message = "Update Fail !",
                is_erro = true
            });
        }

        [HttpGet("info")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleVM>> Search(string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId)
        {
            return await _VehicleService.Search(customerId, makeId, modelId, odometer, VIN, engine, appuserId);
        }

        [HttpGet("{id}/condition")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<ConditionVM>> GetAllConditionById(int id)
        {
            return await _VehicleService.GetAllConditionById(id);
        }

        [HttpGet("{id}/appraisalvalue")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleAppraisalVM>> GetAllappraisalValueById(int id)
        {
            return await _VehicleService.GetAllAppraisalValueById(id);
        }
    }
}
