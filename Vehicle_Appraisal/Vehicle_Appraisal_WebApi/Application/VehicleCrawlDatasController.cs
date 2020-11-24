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
    [Authorize(Roles ="Admin")]
    public class VehicleCrawlDatasController : ControllerBase
    {
        private readonly IVehicleCrawlDataService _vehicleCrawlDataService;
        public VehicleCrawlDatasController(IVehicleCrawlDataService vehicleCrawlDataService)
        {
            _vehicleCrawlDataService = vehicleCrawlDataService;
        }
        [HttpGet]
        public async Task<List<VehicleCrawlDataVM>> GetAllVehicleCrawlData()
        {
            return await _vehicleCrawlDataService.GetAllVehicleCrawlData();
        }
    }
}
