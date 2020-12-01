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
    public class CustomerController : Controller
    {
        private readonly ICustomerServiceApiClient _customerServiceApiClient;

        public CustomerController(ICustomerServiceApiClient customerServiceApiClient)
        {
            _customerServiceApiClient = customerServiceApiClient;
        }

        // GET customer/insert
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        // GET customer/update
        [HttpGet]
        public IActionResult Update(CustomerVM CustomerVM)
        {
            return View(CustomerVM);
        }

        // GET customer/getall
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            string token = HttpContext.Session.GetString("token_access");
            var list = await _customerServiceApiClient.GetAll(token);
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

        // GET customer/getbyid
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _customerServiceApiClient.GetById(id, token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        // GET customer/deleteaction
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _customerServiceApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return RedirectToAction("GetAll", "customer");
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return RedirectToAction("GetAll", "customer");
            }
        }

        // POST customer/insertaction
        [HttpPost]
        public async Task<IActionResult> InsertAction(CustomerVM CustomerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _customerServiceApiClient.Insert(CustomerVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "customer");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Insert", CustomerVM);
                }
            }
            else
                return View("Insert", CustomerVM);
        }

        // POST customer/updateaction
        [HttpPost]
        public async Task<IActionResult> UpdateAction(CustomerVM CustomerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _customerServiceApiClient.Update(CustomerVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "customer");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Update", CustomerVM);
                }
            }
            else
                return View("Update", CustomerVM);
        }

        // GET customer/searchaction
        [HttpGet]
        public async Task<IActionResult> SearchAction(string name, string phone, string email, string address, string city, string country)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _customerServiceApiClient.Search(token, name, phone, email, address, city, country);
                return View("GetAll", list);
            }
            else
                return BadRequest("Error 400");
        }
    }
}