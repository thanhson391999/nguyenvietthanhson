﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebMVC.Models;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    [Authorize(Roles = "Admin,Users")]
    public class HomeController : Controller
    {
        private readonly ICustomerServiceApiClient _customerServiceApiClient;
        private readonly IVehicleServiceApiClient _vehicleServiceApiClient;
        private readonly IUserServiceApiClient _userServiceApiClient;

        public HomeController(ICustomerServiceApiClient customerServiceApiClient, IVehicleServiceApiClient vehicleServiceApiClient, IUserServiceApiClient userServiceApiClient)
        {
            _customerServiceApiClient = customerServiceApiClient;
            _userServiceApiClient = userServiceApiClient;
            _vehicleServiceApiClient = vehicleServiceApiClient;
        }

        // GET home/index
        [HttpGet]
        public async Task<IActionResult> index()
        {
            string token = HttpContext.Session.GetString("token_access");
            var customerVMs = await _customerServiceApiClient.GetAll(token);
            var vehicleVMs = await _vehicleServiceApiClient.GetAllNotBuy(token);
            var userVMs = await _userServiceApiClient.GetAll(token);
            var dashboard = new DashBoardModelMVC
            {
                ListAppuserVM = userVMs.Select(x => x.appUserVM).ToList(),
                ListCustomerVM = customerVMs,
                ListVehicleVM = vehicleVMs
            };
            if (TempData["SuccessResult"] != null)
            {
                ViewBag.SuccessMsg = TempData["SuccessResult"];
            }
            return View(dashboard);
        }

        // GET home/privacy
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
