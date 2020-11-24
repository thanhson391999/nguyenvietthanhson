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
    public class ModelController : Controller
    {
        private readonly IModelServiceApiClient _modelServiceApiClient;
        public ModelController(IModelServiceApiClient modelServiceApiClient)
        {
            _modelServiceApiClient = modelServiceApiClient;
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Update(ModelVM modelVM)
        {
            return View(modelVM);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _modelServiceApiClient.GetAll(token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _modelServiceApiClient.GetById(id, token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _modelServiceApiClient.Delete(id, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "model");
                }
                else
                    return Ok("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> InsertAction(ModelVM modelVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _modelServiceApiClient.Insert(modelVM, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "model");
                }
                else
                    return Ok("Insert Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAction(ModelVM modelVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _modelServiceApiClient.Update(modelVM, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "model");
                }
                else
                    return Ok("Update Fail !");
            }
            else
                return BadRequest("Error 400");
        }
    }
}
