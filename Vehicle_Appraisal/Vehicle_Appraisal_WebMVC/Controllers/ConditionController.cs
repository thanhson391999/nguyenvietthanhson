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
    [Authorize(Roles ="Admin,Users")]
    public class ConditionController : Controller
    {
        private readonly IConditionServiceApiClient _conditionServiceApiClient;
        public ConditionController(IConditionServiceApiClient conditionServiceApiClient)
        {
            _conditionServiceApiClient = conditionServiceApiClient;
        }
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id, int vehicleId)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _conditionServiceApiClient.Delete(id, token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllConditionById/" + vehicleId);
                }
                else
                    return Ok("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }
        public IActionResult Insert(int id)
        {
            var conditionVM = new ConditionVM();
            conditionVM.VehicleId = id;
            return View(conditionVM);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> InsertAction(ConditionVM conditionVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                if (conditionVM.file != null)
                {
                    string image = await _conditionServiceApiClient.UploadImage(conditionVM.file, token);
                    conditionVM.ImagePath = image;
                }
                var result = await _conditionServiceApiClient.Insert(conditionVM, token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllConditionById/"+conditionVM.VehicleId);
                }
                else
                    return Ok("Insert Fail !");
            }
            return BadRequest("Error 400");
        }
        public IActionResult Update(ConditionVM conditionVM)
        {
            return View(conditionVM);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateAction(ConditionVM conditionVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                if (conditionVM.file != null)
                {
                    string image = await _conditionServiceApiClient.UploadImage(conditionVM.file, token);
                    conditionVM.ImagePath = image;
                }
                var result = await _conditionServiceApiClient.Update(conditionVM, token);
                if (result)
                {
                    return Redirect("/vehicle/GetAllConditionById/" + conditionVM.VehicleId);
                }
                else
                    return Ok("Update Fail !");
            }
            return BadRequest("Error 400");
        }
    }
}
