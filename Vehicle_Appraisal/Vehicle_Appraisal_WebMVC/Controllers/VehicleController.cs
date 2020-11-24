using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;
using Vehicle_Appraisal_WebMVC.Service;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ICustomerServiceApiClient _customerServiceApiClient;
        private readonly IVehicleServiceApiClient _vehicleServiceApiClient;
        private readonly IMakeServiceApiClient _makeServiceApiClient;
        private readonly IUserServiceApiClient _userServiceApiClient;
        private readonly IModelServiceApiClient _modelServiceApiClient;

        public VehicleController(IVehicleServiceApiClient vehicleServiceApiClient, IUserServiceApiClient userServiceApiClient, IMakeServiceApiClient makeServiceApiClient, ICustomerServiceApiClient customerServiceApiClient, IModelServiceApiClient modelServiceApiClient)
        {
            _userServiceApiClient = userServiceApiClient;
            _makeServiceApiClient = makeServiceApiClient;
            _modelServiceApiClient = modelServiceApiClient;
            _customerServiceApiClient = customerServiceApiClient;
            _vehicleServiceApiClient = vehicleServiceApiClient;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(VehicleModelMVC vehicleModelMVC)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var customers = await _customerServiceApiClient.GetAll(token);
                var makes = await _makeServiceApiClient.GetAll(token);
                var models = await _modelServiceApiClient.GetAll(token);
                var appusers = await _userServiceApiClient.GetAll(token);
                vehicleModelMVC.ListCustomerVM = customers;
                vehicleModelMVC.ListMakeVM = makes;
                vehicleModelMVC.ListModelVM = models;
                vehicleModelMVC.ListAppUserVM = appusers.Select(x=>x.appUserVM).ToList();
                return View(vehicleModelMVC);
            }
            return BadRequest("Error 400");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(VehicleVM VehicleVM,CustomerVM CustomerVM, MakeVM MakeVM, AppUserVM appUserVM)
        {
            var vehicleModelMVC = new VehicleModelMVC()
            {
                customerVM = CustomerVM,
                makeVM = MakeVM,
                vehicleVM = VehicleVM,
                appUserVM = appUserVM
            };
            string token = HttpContext.Session.GetString("token_access");
            var customers = await _customerServiceApiClient.GetAll(token);
            var makes = await _makeServiceApiClient.GetAll(token);
            var models = await _modelServiceApiClient.GetAll(token);
            var appuers = await _userServiceApiClient.GetAll(token);
            vehicleModelMVC.ListCustomerVM = customers;
            vehicleModelMVC.ListMakeVM = makes;
            vehicleModelMVC.ListModelVM = models;
            vehicleModelMVC.ListAppUserVM = appuers.Select(x=>x.appUserVM).ToList();
            var model = await _modelServiceApiClient.GetById(VehicleVM.ModelId,token);
            vehicleModelMVC.modelVM = model;
            return View(vehicleModelMVC);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAll(token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var vehicle = await _vehicleServiceApiClient.GetById(id, token);
                return View(vehicle);
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAction(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleServiceApiClient.Delete(id, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "vehicle");
                }
                else
                    return Ok("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertAction(VehicleModelMVC vehicleModelMVC)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleServiceApiClient.Insert(vehicleModelMVC, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "vehicle");
                }
                else
                    return Ok("Insert Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAction(VehicleModelMVC vehicleModelMVC)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleServiceApiClient.Update(vehicleModelMVC, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "vehicle");
                }
                else
                    return Ok("Update Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SearchAction(string customer, string make, string model, string odometer, string VIN, string engine, string appuser)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.Search(token, customer, make, model, odometer, VIN, engine, appuser);
                return View("GetAll", list);
            }
            else
                return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> GetAllConditionById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAllConditionById(id, token);
                if (list.Count == 0)
                {
                    var conditionVMs = new List<ConditionVM>();
                    var conditionVM = new ConditionVM();
                    conditionVM.VehicleId = id;
                    conditionVMs.Add(conditionVM);
                    return View(conditionVMs);
                }
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllAppraisalValueById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAllAppraisalValueById(id, token);
                if (list.Count == 0)
                {
                    var vehicleAppraisalVMs = new List<VehicleAppraisalVM>();
                    var vehicleAppraisalVM = new VehicleAppraisalVM();
                    vehicleAppraisalVM.VehicleId = id;
                    vehicleAppraisalVMs.Add(vehicleAppraisalVM);
                    return View(vehicleAppraisalVMs);
                }
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }
    }
}
