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

        // GET api/vehicles
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<VehicleVM>> GetAll()
        {
            return await _VehicleService.GetAll();
        }

        // GET api/vehicles/not-buy
        [HttpGet("not-buy")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<VehicleVM>> GetAllNotBuy()
        {
            return await _VehicleService.GetAllNotBuy();
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

        // GET api/vehicles/{id}/conditions
        [HttpGet("{id}/conditions")]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<ConditionVM>> GetAllConditionById(int id)
        {
            return await _VehicleService.GetAllConditionById(id);
        }

        // GET api/vehicles/{id}/appraisalvalues
        [HttpGet("{id}/appraisalvalues")]
        [Authorize(Roles = "Admin")]
        public async Task<List<VehicleAppraisalVM>> GetAllappraisalValueById(int id)
        {
            return await _VehicleService.GetAllAppraisalValueById(id);
        }

        // GET api/vehicles/buyvehicle/{id}
        [HttpGet("buyvehicle/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> BuyVehicle(int id)
        {
            var result = await _VehicleService.BuyVehicle(id);
            return Ok(result);
        }

        // GET api/vehicles/date
        [HttpGet("date")]
        [Authorize(Roles ="Admin")]
        public async Task<List<VehicleVM>> SearchDate(DateTime fromDate, DateTime toDate)
        {
            return await _VehicleService.SearchDate(fromDate, toDate);
        }
    }
}
