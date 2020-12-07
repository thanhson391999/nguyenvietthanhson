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
    public class VehicleCrawlDatasController : ControllerBase
    {
        private readonly IVehicleCrawlDataService _vehicleCrawlDataService;

        public VehicleCrawlDatasController(IVehicleCrawlDataService vehicleCrawlDataService)
        {
            _vehicleCrawlDataService = vehicleCrawlDataService;
        }

        // GET api/vehiclecrawldatas/BMW/paging
        [HttpGet("bmw/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleBMWCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleBMWCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/audi/paging
        [HttpGet("audi/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleAudiCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleAudiCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/ford/paging
        [HttpGet("ford/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleFordCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleFordCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/honda/paging
        [HttpGet("honda/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHondaCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleHondaCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/hyundai/paging
        [HttpGet("hyundai/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleHyundaiCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleHyundaiCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/lexus/paging
        [HttpGet("lexus/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleLexusCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleLexusCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/mitsubishi/paging
        [HttpGet("mitsubishi/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleMitsubishiCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleMitsubishiCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/suzuki/paging
        [HttpGet("suzuki/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleSuzukiCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleSuzukiCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/toyota/paging
        [HttpGet("toyota/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleToyotaCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleToyotaCrawlData(paginationVM);
        }

        // GET api/vehiclecrawldatas/vinfast/paging
        [HttpGet("vinfast/paging")]
        public async Task<PageResultVM<VehicleCrawlDataVM>> GetAllVehicleVinfastCrawlData([FromQuery] PaginationVM paginationVM)
        {
            return await _vehicleCrawlDataService.GetAllVehicleVinfastCrawlData(paginationVM);
        }
    }
}
