using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        // GET model/insert
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        // GET model/update
        [HttpGet]
        public IActionResult Update(ModelVM modelVM)
        {
            return View(modelVM);
        }

        // GET model/getall
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageIndex = 1)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var paginationVM = new PaginationVM()
                {
                    PageIndex = pageIndex
                };
                var list = await _modelServiceApiClient.GetAllPaging(token, paginationVM);
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

        // GET model/getbyid
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

        // GET model/deleteaction
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _modelServiceApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return RedirectToAction("GetAll", "model");
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return RedirectToAction("GetAll", "model");
            }
        }

        // POST model/insertaction
        [HttpPost]
        public async Task<IActionResult> InsertAction(ModelVM modelVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _modelServiceApiClient.Insert(modelVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "model");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Insert", modelVM);
                }
            }
            else
                return View("Insert", modelVM);
        }

        // POST model/updateaction
        [HttpPost]
        public async Task<IActionResult> UpdateAction(ModelVM modelVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _modelServiceApiClient.Update(modelVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "model");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Update", modelVM);
                }
            }
            else
                return View("Update", modelVM);
        }
    }
}
