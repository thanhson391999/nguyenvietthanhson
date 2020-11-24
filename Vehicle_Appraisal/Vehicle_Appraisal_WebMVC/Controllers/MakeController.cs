using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.sun.java.swing.plaf.windows.resources;
using java.awt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Service;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MakeController : Controller
    {
        private readonly IMakeServiceApiClient _makeServiceApiClient;
        public MakeController(IMakeServiceApiClient makeServiceApiClient)
        {
            _makeServiceApiClient = makeServiceApiClient;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _makeServiceApiClient.GetAll(token);
                return View(list);
            }
            return BadRequest("Error 400 !");
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int Id)
        {
            if(ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _makeServiceApiClient.GetById(Id, token);
                return View(list);
            }
            return BadRequest("Error 400 !");
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertAction(MakeVM makeVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _makeServiceApiClient.Insert(makeVM, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "make");
                }
                else
                    return Ok("Insert Fail !");
            }
            return BadRequest("Error 400 !");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _makeServiceApiClient.Delete(id,token);
                if (result)
                {
                    return RedirectToAction("GetAll", "Make");
                }
                else
                    return Ok("Delete Fail !");
            }
            return BadRequest("Error 400 !");
        }

        public IActionResult Update(MakeVM makeVM)
        {
            return View(makeVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAction(MakeVM makeVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _makeServiceApiClient.Update(makeVM,token);
                if (result)
                {
                    return RedirectToAction("GetAll", "Make");
                }
                else
                    return Ok("Update Fail !");
            }
            return BadRequest("Error 400 !");
        }
    }
}
