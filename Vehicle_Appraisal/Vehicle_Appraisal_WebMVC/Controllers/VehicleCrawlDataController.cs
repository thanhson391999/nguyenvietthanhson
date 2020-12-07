using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class VehicleCrawlDataController : Controller
    {
        private readonly IVehicleCrawlDataServiceApiClient _vehicleCrawlDataServiceApiClient;

        public VehicleCrawlDataController(IVehicleCrawlDataServiceApiClient vehicleCrawlDataServiceApiClient)
        {
            _vehicleCrawlDataServiceApiClient = vehicleCrawlDataServiceApiClient;
        }

        // GET vehiclecrawldata/getallvehicleBMWcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleBMWCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleBMWCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehicleaudicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleAudiCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleAudiCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclevinfastcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleVinfastCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleVinfastCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclefordcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleFordCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleFordCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclehondacrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleHondaCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleHondaCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclelexuscrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleLexusCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleLexusCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclesuzukicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleSuzukiCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleSuzukiCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehicletoyotacrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleToyotaCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleToyotaCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclehyundaicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleHyundaiCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleHyundaiCrawlData(token, paginationVM);
            return View(pageResultVM);
        }

        // GET vehiclecrawldata/getallvehiclemitsubishicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleMitsubishiCrawlData(int pageIndex = 1)
        {
            string token = HttpContext.Session.GetString("token_access");
            var paginationVM = new PaginationVM
            {
                PageIndex = pageIndex
            };
            var pageResultVM = await _vehicleCrawlDataServiceApiClient.GetAllVehicleMitsubishiCrawlData(token, paginationVM);
            return View(pageResultVM);
        }
    }
}
