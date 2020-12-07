using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
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

        // GET api/vehicles
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<VehicleVM>> GetAll()
        {
            return await _VehicleService.GetAll();
        }

        // GET api/vehicles/not-buy
        [HttpGet("not-buy")]
        [Authorize(Roles = "Admin, Users")]
        public async Task<List<VehicleVM>> GetAllNotBuy()
        {
            return await _VehicleService.GetAllNotBuy();
        }

        // GET api/vehicles/paging
        [HttpGet("paging")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<PageResultVM<VehicleVM>> GetAllPaging([FromQuery] PaginationVM paginationVM)
        {
            return await _VehicleService.GetAllPaging(paginationVM);
        }

        // GET api/vehicles/Vehicle-bought/paging
        [HttpGet("vehicle-bought/paging")]
        [Authorize(Roles = "Admin")]
        public async Task<PageResultVM<VehicleVM>> GetAllVehicleBoughtPaging(DateTime fromDate, DateTime toDate, [FromQuery] PaginationVM paginationVM)
        {
            return await _VehicleService.GetAllVehicleBoughtPaging(fromDate, toDate, paginationVM);
        }

        // GET api/vehicles/{id}/conditions/paging
        [HttpGet("{id}/conditions/paging")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<PageResultVM<ConditionVM>> GetAllConditionByIdPaging(int id, [FromQuery] PaginationVM paginationVM)
        {
            return await _VehicleService.GetAllConditionByIdPaging(id, paginationVM);
        }

        // GET api/vehicles/vehicle-bought
        [HttpGet("vehicle-bought")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleVM>> GetAllVehicleBought()
        {
            return await _VehicleService.GetAllVehicleBought();
        }

        // GET api/vehicles/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<VehicleVM> GetById(int id)
        {
            return await _VehicleService.GetById(id);
        }

        // DELETE api/vehicles/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _VehicleService.Delete(id);
            return Ok(result);
        }

        // POST api/vehicles
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(VehicleVM VehicleVM)
        {
            var result = await _VehicleService.Insert(VehicleVM);
            return Ok(result);
        }

        // PUT api/vehicles/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(VehicleVM VehicleVM, int id)
        {
            var result = await _VehicleService.Update(VehicleVM, id);
            return Ok(result);
        }

        // GET api/vehicles/info
        [HttpGet("info")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleVM>> Search(string customerId, string makeId, string modelId, string odometer, string VIN, string engine, string appuserId)
        {
            return await _VehicleService.Search(customerId, makeId, modelId, odometer, VIN, engine, appuserId);
        }

        // GET api/vehicles/{id}/appraisal-values
        [HttpGet("{id}/appraisal-values")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleAppraisalVM>> GetAllappraisalValueById(int id)
        {
            return await _VehicleService.GetAllAppraisalValueById(id);
        }

        // DELETE api/vehicles/vehicle-buy/{id}
        [HttpDelete("vehicle-buy/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> BuyVehicle(int id)
        {
            var result = await _VehicleService.BuyVehicle(id);
            return Ok(result);
        }
    }
}
