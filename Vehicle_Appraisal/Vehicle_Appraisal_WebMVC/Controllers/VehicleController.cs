using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;
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

        private async Task<VehicleVM> listChosen(string token, VehicleModelMVC vehicleModelMVC)
        {
            var customers = await _customerServiceApiClient.GetAll(token);
            var makes = await _makeServiceApiClient.GetAll(token);
            var models = await _modelServiceApiClient.GetAll(token);
            var appusers = await _userServiceApiClient.GetAll(token);
            vehicleModelMVC.CustomerVMs = customers;
            vehicleModelMVC.MakeVMs = makes;
            vehicleModelMVC.ModelVMs = models;
            vehicleModelMVC.AppUserVMs = appusers.Select(x => x.appUserVM).ToList();
            return vehicleModelMVC;
        }

        // GET vehicle/insert
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                return View(await listChosen(token, new VehicleModelMVC()));
            }
            return BadRequest("Error 400");
        }

        // GET vehicle/update
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(VehicleVM vehicleVM, AppUserVM appUserVM, CustomerVM customerVM,string makeName, string modelName)
        {
            vehicleVM.MakeVM = new MakeVM
            {
                Name = makeName
            };
            vehicleVM.ModelVM = new ModelVM
            {
                Name = modelName
            };
            var vehicleModelMVC = new VehicleModelMVC
            {
                Id = vehicleVM.Id,
                CreateAt = vehicleVM.CreateAt,
                CustomerVM = customerVM,
                MakeVM = vehicleVM.MakeVM,
                ModelVM = vehicleVM.ModelVM,
                AppUserVM = appUserVM,
                Odometer = vehicleVM.Odometer,
                VIN = vehicleVM.VIN,
                Engine = vehicleVM.Engine
            };
            string token = HttpContext.Session.GetString("token_access");
            return View(await listChosen(token, vehicleModelMVC));
        }

        // GET vehicle/getall
        [HttpGet]
        [Authorize(Roles = "Admin, Users")]
        public async Task<IActionResult> GetAll(string keyWord, string subjects, int pageIndex = 1)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var paginationSearchVM = new PaginationSearchVM()
                {
                    PageIndex = pageIndex,
                    keyWord = keyWord,
                    subjects = subjects
                };
                var list = await _vehicleServiceApiClient.GetAllPaging(token, paginationSearchVM);
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

        // GET vehicle/getallconditionbyid
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> GetAllConditionById(int id, int i, bool isBought, int pageIndex = 1)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var paginationVM = new PaginationVM()
                {
                    PageIndex = pageIndex
                };
                var list = await _vehicleServiceApiClient.GetAllConditionByIdPaging(token, id, paginationVM);
                if (TempData["ErrorResult"] != null)
                {
                    ViewBag.ErrorMsg = TempData["ErrorResult"];
                }
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                ViewBag.id = id;
                ViewBag.i = i;
                ViewBag.isBought = isBought;
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }

        // GET vehicle/getallappraisalvaluebyid
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllAppraisalValueById(int id, int i, bool isBought)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _vehicleServiceApiClient.GetAllAppraisalValueById(id, token);
                if (TempData["ErrorResult"] != null)
                {
                    ViewBag.ErrorMsg = TempData["ErrorResult"];
                }
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                ViewBag.id = id;
                ViewBag.i = i;
                ViewBag.isBought = isBought;
                return View(list);
            }
            else
                return BadRequest("Error 400");
        }

        // DELETE vehicle/buyvehicle/{id}
        [HttpDelete]
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
        public async Task<IActionResult> GetAllVehicleBought(DateTime fromDate, DateTime toDate, int pageIndex = 1)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var paginationVM = new PaginationVM
                {
                    PageIndex = pageIndex,
                };
                var list = await _vehicleServiceApiClient.GetAllVehicleBoughtPaging(token, fromDate, toDate, paginationVM);
                return View(list);
            }
            return BadRequest("Error 400");
        }
    }
}
