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
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Update(CustomerVM CustomerVM)
        {
            return View(CustomerVM);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _customerServiceApiClient.GetAll(token);
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
                var list = await _customerServiceApiClient.GetById(id,token);
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
                var result = await _customerServiceApiClient.Delete(id,token);
                if (result)
                {
                    return RedirectToAction("GetAll", "customer");
                }
                else
                    return Ok("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> InsertAction(CustomerVM CustomerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _customerServiceApiClient.Insert(CustomerVM,token);
                if (result)
                {
                    return RedirectToAction("GetAll", "customer");
                }
                else
                    return Ok("Insert Fail !");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAction(CustomerVM CustomerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _customerServiceApiClient.Update(CustomerVM,token);
                if (result)
                {
                    return RedirectToAction("GetAll", "customer");
                }
                else
                    return Ok("Update Fail !");
            }
            else
                return BadRequest("Error 400");
        }

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