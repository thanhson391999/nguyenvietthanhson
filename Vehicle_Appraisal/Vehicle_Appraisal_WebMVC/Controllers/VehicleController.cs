using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        private readonly IVehicleAppraisalServiceApiClient _vehicleAppraisalServiceApiClient;

        public VehicleController(IVehicleServiceApiClient vehicleServiceApiClient,
                                 IUserServiceApiClient userServiceApiClient,
                                 IMakeServiceApiClient makeServiceApiClient,
                                 ICustomerServiceApiClient customerServiceApiClient,
                                 IModelServiceApiClient modelServiceApiClient,
                                 IVehicleAppraisalServiceApiClient vehicleAppraisalServiceApiClient)
        {
            _vehicleAppraisalServiceApiClient = vehicleAppraisalServiceApiClient;
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
                TempData["vehicleVMs"] = JsonConvert.SerializeObject(list.Items);
                return View(list);
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> FileExportVehicleBought()
        {
            string token = HttpContext.Session.GetString("token_access");
            if (TempData["vehicleVMs"] == null)
            {
                return Redirect("/vehicle/GetAllVehicleBought");
            }
            var vehicleVMs = JsonConvert.DeserializeObject<List<VehicleVM>>(TempData["vehicleVMs"].ToString());
            var vehicleAppraisalVMs = await _vehicleAppraisalServiceApiClient.GetAll(token);
            var query = (from _vehicleAppraisalVMs in vehicleAppraisalVMs
                         join _vehicleVMs in vehicleVMs on _vehicleAppraisalVMs.VehicleId equals _vehicleVMs.Id
                         select new VehicleAppraisalVM
                         {
                             VehicleVM = _vehicleVMs,
                             AppraisalValue = _vehicleAppraisalVMs.AppraisalValue
                         }).ToList();
            using (var workBook = new XLWorkbook())
            {
                int rowHeader = 2;
                int columnHeader = 1;
                int row = 2;
                int column = 1;
                workBook.Properties.Author = "Thanh Sơn";
                workBook.Properties.Title = "Report Vehicles Bought";
                var workSheet = workBook.Worksheets.Add("Vehicles Bought");
                workSheet.Cell(rowHeader, columnHeader++).Value = "Date";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Customer";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Make";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Model";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Odometer";
                workSheet.Cell(rowHeader, columnHeader++).Value = "VIN";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Engine";
                workSheet.Cell(rowHeader, columnHeader++).Value = "Appraisal Value";
                foreach (var item in query)
                {
                    row++;
                    column = 1;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.UpdateAt.ToString("dd/MM/yyyy");
                    workSheet.Cell(row, column++).Value = item.VehicleVM.CustomerVM.FirstName+" "+item.VehicleVM.CustomerVM.LastName;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.MakeVM.Name;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.ModelVM.Name;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.Odometer;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.VIN;
                    workSheet.Cell(row, column++).Value = item.VehicleVM.Engine;
                    workSheet.Cell(row, column).Value = item.AppraisalValue;
                    workSheet.Cell(row, column).Style.NumberFormat.Format = "#,## " + "\"VND\"";
                }
                row +=2;
                workSheet.Cell(row, column).Value = query.Count();
                workSheet.Cell(row, column - 1).Value = "Total Vehicles :";
                workSheet.Cell(row, column - 1).Style.Font.SetBold();
                row++;
                workSheet.Cell(row, column).FormulaA1 = "SUM(H3:H" + (query.Count() + 2) + ")";
                workSheet.Cell(row, column).Style.NumberFormat.Format = "#,## " + "\"VND\"";
                workSheet.Cell(row, column - 1).Value = "Total Value :";
                workSheet.Cell(row, column - 1).Style.Font.SetBold();

                var rangeTextTitle = workSheet.Range("A1:H1");
                rangeTextTitle.Merge();
                rangeTextTitle.Value = "REPORT OF VEHICLES BOUGHT";
                rangeTextTitle.Style.Font.SetBold();
                rangeTextTitle.Style.Font.SetFontSize(16);
                rangeTextTitle.Style.Fill.BackgroundColor = XLColor.LightGreen;
                rangeTextTitle.Style.Font.SetFontColor(XLColor.Red);

                var rangeTextHeader = workSheet.Range("A2:H2");
                rangeTextHeader.Style.Font.SetFontColor(XLColor.Red);
                rangeTextHeader.Style.Font.SetBold();
                workSheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                workSheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                workSheet.Columns().AdjustToContents();
                workSheet.Rows().AdjustToContents();
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    var fileName = "VehicleBought.xlsx";
                    return File(content, contentType, fileName);
                }
            }
        }
    }
}
