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

        private async Task<VehicleModelMVC> listChosen(string token, VehicleModelMVC vehicleModelMVC)
        {
            var customers = await _customerServiceApiClient.GetAll(token);
            var makes = await _makeServiceApiClient.GetAll(token);
            var models = await _modelServiceApiClient.GetAll(token);
            var appusers = await _userServiceApiClient.GetAll(token);
            vehicleModelMVC.ListCustomerVM = customers;
            vehicleModelMVC.ListMakeVM = makes;
            vehicleModelMVC.ListModelVM = models;
            vehicleModelMVC.ListAppUserVM = appusers.Select(x => x.appUserVM).ToList();
            return vehicleModelMVC;
        }

        // GET vehicle/insert
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert()
        {
            if (ModelState.IsValid)
            {
                var vehicleModelMVC = new VehicleModelMVC();
                string token = HttpContext.Session.GetString("token_access");
                return View(await listChosen(token, vehicleModelMVC));
            }
            return BadRequest("Error 400");
        }

        // GET vehicle/update
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int Id, string Odometer, string VIN, string Engine, string MakeName, string FullName, string ModelName, string FirstName, string LastName)
        {
            var vehicleVM = new VehicleVM()
            {
                Id = Id,
                Odometer = Odometer,
                VIN = VIN,
                Engine = Engine
            };
            var customerVM = new CustomerVM()
            {
                FirstName = FirstName,
                LastName = LastName
            };
            var makeVM = new MakeVM()
            {
                Name = MakeName
            };
            var modelVM = new ModelVM()
            {
                Name = ModelName
            };
            var appUserVM = new AppUserVM()
            {
                FullName = FullName
            };
            var vehicleModelMVC = new VehicleModelMVC()
            {
                customerVM = customerVM,
                makeVM = makeVM,
                modelVM = modelVM,
                vehicleVM = vehicleVM,
                appUserVM = appUserVM
            };
            string token = HttpContext.Session.GetString("token_access");
            return View(await listChosen(token, vehicleModelMVC));
        }

        // GET vehicle/getall
        [HttpGet]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAll(token);
                if (TempData["ErrorResult"] != null)
                {
                    ViewBag.ErrorMsg = TempData["ErrorResult"];
                }
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                return View(list);
            }
            return BadRequest("Error 400");
        }

        // GET vehicle/getbyid
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

        // GET vehicle/deleteaction
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAction(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _vehicleServiceApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return RedirectToAction("GetAll", "vehicle");
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return RedirectToAction("GetAll", "vehicle");
            }
        }

        // POST vehicle/insertaction
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertAction(VehicleModelMVC vehicleModelMVC)
        {
            string token = HttpContext.Session.GetString("token_access");
            if (ModelState.IsValid)
            {
                var result = await _vehicleServiceApiClient.Insert(vehicleModelMVC, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "vehicle");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Insert", await listChosen(token, vehicleModelMVC));
                }
            }
            else
            {
                return View("Insert", await listChosen(token, vehicleModelMVC));
            }
        }

        // POST vehicle/updateaction
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAction(VehicleModelMVC vehicleModelMVC)
        {
            string token = HttpContext.Session.GetString("token_access");
            if (ModelState.IsValid)
            {
                var result = await _vehicleServiceApiClient.Update(vehicleModelMVC, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "vehicle");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Update", await listChosen(token, vehicleModelMVC));
                }
            }
            else
            {
                return View("Update", await listChosen(token, vehicleModelMVC));
            }
        }

        // GET vehicle/searchaction
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

        // GET vehicle/getallconditionbyid
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
                if (TempData["ErrorResult"] != null)
                {
                    ViewBag.ErrorMsg = TempData["ErrorResult"];
                }
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }

        // GET vehicle/getallappraisalvaluebyid
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
                if (TempData["ErrorResult"] != null)
                {
                    ViewBag.ErrorMsg = TempData["ErrorResult"];
                }
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }

        // GET vehicle/buyvehicle
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> BuyVehicle(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _vehicleServiceApiClient.BuyVehicle(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return Redirect("/vehicle/GetAll");
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return Redirect("/vehicle/GetAll");
            }
        }

        // GET vehicle/getallvehiclebought
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllVehicleBought()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAllVehicleBought(token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        // GET vehicle/searchdate
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SearchDate(DateTime fromDate, DateTime toDate)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.SearchDate(fromDate, toDate, token);
                return View("GetAllVehicleBought", list);
            }
            return BadRequest("Error 400");
        }
    }
}
