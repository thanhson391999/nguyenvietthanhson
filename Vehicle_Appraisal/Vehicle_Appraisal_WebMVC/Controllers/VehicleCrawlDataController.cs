using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        private async Task<List<VehicleCrawlDataVM>> ListVehicleCrawlData()
        {
            string token = HttpContext.Session.GetString("token_access");
            return await _vehicleCrawlDataServiceApiClient.GetAllVehicleCrawlData(token);
        }

        // GET vehiclecrawldata/getallvehiclebmwcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleBMWCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehicleaudicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleAudiCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclevinfastcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleVinfastCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclefordcrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleFordCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclehondacrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleHondaCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclelexuscrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleLexusCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclesuzukicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleSuzukiCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehicletoyotacrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleToyotaCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclehyundaicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleHyundaiCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }

        // GET vehiclecrawldata/getallvehiclemitsubishicrawldata
        [HttpGet]
        public async Task<IActionResult> GetAllVehicleMitsubishiCrawlData()
        {
            return View(await ListVehicleCrawlData());
        }
    }
}
