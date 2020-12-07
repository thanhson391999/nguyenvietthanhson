using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class VehicleAppraisalController : Controller
    {
        private readonly IVehicleAppraisalServiceApiClient _vehicleAppraisalApiClient;

        public VehicleAppraisalController(IVehicleAppraisalServiceApiClient vehicleAppraisalApiClient)
        {
            _vehicleAppraisalApiClient = vehicleAppraisalApiClient;
        }

        // GET vehicleappraisal/deleteaction
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id, int vehicleId)
        {

            string token = HttpContext.Session.GetString("token_access");
            var result = await _vehicleAppraisalApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleId);
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleId);
            }
        }

        // GET vehicleappraisal/insert
        [HttpGet]
        public IActionResult Insert(int id)
        {
            var vehicleappraisalVM = new VehicleAppraisalVM();
            vehicleappraisalVM.VehicleId = id;
            return View(vehicleappraisalVM);
        }

        // POST vehicleappraisal/insertaction
        [HttpPost]
        public async Task<IActionResult> InsertAction(VehicleAppraisalVM vehicleAppraisalVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleAppraisalApiClient.Insert(vehicleAppraisalVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleAppraisalVM.VehicleId);
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Insert", vehicleAppraisalVM);
                }
            }
            else
                return View("Insert", vehicleAppraisalVM);
        }

        // GET vehicleappraisal/update
        [HttpGet]
        public IActionResult Update(VehicleAppraisalVM vehicleAppraisalVM)
        {
            return View(vehicleAppraisalVM);
        }

        // POST vehicleappraisal/updateaction
        [HttpPost]
        public async Task<IActionResult> UpdateAction(VehicleAppraisalVM vehicleAppraisalVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _vehicleAppraisalApiClient.Update(vehicleAppraisalVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return Redirect("/vehicle/GetAllAppraisalValueById/" + vehicleAppraisalVM.VehicleId);
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Update", vehicleAppraisalVM);
                }
            }
            else
                return View("Update", vehicleAppraisalVM);
        }
    }
}
