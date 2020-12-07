using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;
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

        // GET make/getall
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
                var list = await _makeServiceApiClient.GetAllPaging(token, paginationVM);
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
            return BadRequest("Error 400 !");
        }

        // GET make/getbyid
        [HttpGet]
        public async Task<IActionResult> GetById(int Id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _makeServiceApiClient.GetById(Id, token);
                return View(list);
            }
            return BadRequest("Error 400 !");
        }

        // GET make/insert
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        // POST make/insertaction
        [HttpPost]
        public async Task<IActionResult> InsertAction(MakeVM makeVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _makeServiceApiClient.Insert(makeVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "make");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Insert", makeVM);
                }
            }
            return View("Insert", makeVM);
        }

        // GET make/deleteaction
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _makeServiceApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return RedirectToAction("GetAll", "Make");
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return RedirectToAction("GetAll", "Make");
            }
        }

        // GET make/update
        [HttpGet]
        public IActionResult Update(MakeVM makeVM)
        {
            return View(makeVM);
        }

        // POST make/updateaction
        [HttpPost]
        public async Task<IActionResult> UpdateAction(MakeVM makeVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _makeServiceApiClient.Update(makeVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("GetAll", "Make");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Update", makeVM);
                }
            }
            return View("Update", makeVM);
        }
    }
}
