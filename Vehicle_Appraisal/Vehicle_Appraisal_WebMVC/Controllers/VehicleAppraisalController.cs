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
    [Authorize(Roles ="Admin")]
    public class VehicleAppraisalController : Controller
    {
        private readonly IVehicleAppraisalServiceApiClient _vehicleAppraisalApiClient;
        public VehicleAppraisalController(IVehicleAppraisalServiceApiClient vehicleAppraisalApiClient)
        {
            _vehicleAppraisalApiClient = vehicleAppraisalApiClient;
        }
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id, int vehicleId)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleAppraisalApiClient.Delete(id, token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleId);
                }
                else
                    return Ok("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }
        public IActionResult Insert(int id)
        {
            var vehicleappraisalVM = new VehicleAppraisalVM();
            vehicleappraisalVM.VehicleId = id;
            return View(vehicleappraisalVM);
        }
        [HttpPost]
        public async Task<IActionResult> InsertAction([FromForm]VehicleAppraisalVM vehicleAppraisalVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleAppraisalApiClient.Insert(vehicleAppraisalVM, token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllAppraisalValueById/"+vehicleAppraisalVM.VehicleId);
                }
                else
                    return Ok("Insert Fail !");
            }
            else
                return BadRequest("Error 400");
        }
        public IActionResult Update(VehicleAppraisalVM vehicleAppraisalVM)
        {
            return View(vehicleAppraisalVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAction(VehicleAppraisalVM vehicleAppraisalVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleAppraisalApiClient.Update(vehicleAppraisalVM,token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleAppraisalVM.VehicleId);
                }
                else
                    return Ok("Update Fail !");
            }
            else
                return BadRequest("Error 400");
        }
    }
}
