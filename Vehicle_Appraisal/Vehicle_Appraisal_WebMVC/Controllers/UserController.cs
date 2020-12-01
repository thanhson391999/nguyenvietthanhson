using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using sun.security.util;
using Vehicle_Appraisal_WebApi.ViewModels;
using Vehicle_Appraisal_WebMVC.Models;
using Vehicle_Appraisal_WebMVC.Service;
using Vehicle_Appraisal_WebMVC.Service.Interface;

namespace Vehicle_Appraisal_WebMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUserServiceApiClient _userApiClient;
        private readonly IUserRoleServiceApiClient _userRoleServiceApiClient;

        public UserController(IUserServiceApiClient userApiClient, IUserRoleServiceApiClient userRoleServiceApiClient, IConfiguration configuration)
        {
            _userRoleServiceApiClient = userRoleServiceApiClient;
            _configuration = configuration;
            _userApiClient = userApiClient;
        }

        // GET user/info
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public IActionResult Info()
        {
            return View();
        }

        // GET user/updateusers
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateUsers(AppUserVM appUserVM, AppUserRoleVM appUserRoleVM)
        {
            var appUserModelMVC = new AppUserModelMVC();
            string token = HttpContext.Session.GetString("token_access");
            var list = await _userRoleServiceApiClient.GetAll(token);
            appUserModelMVC.ListAppUserRoleVM = list;
            appUserModelMVC.appUserRoleVM = appUserRoleVM;
            appUserModelMVC.appUserVM = appUserVM;
            return View(appUserModelMVC);
        }

        // GET user/login
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (TempData["SuccessResult"] != null)
                {
                    ViewBag.SuccessMsg = TempData["SuccessResult"];
                }
                return RedirectToAction("Index", "Home");
            }
            if (TempData["SuccessResult"] != null)
            {
                ViewBag.SuccessMsg = TempData["SuccessResult"];
            }
            return View();
        }

        // GET user/register
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Register()
        {
            return View();
        }

        // GET user/forgotpassword
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            if (TempData["SuccessResult"] != null)
            {
                ViewBag.SuccessMsg = TempData["SuccessResult"];
            }
            return View();
        }

        // GET user/changepassword
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        // POST user/changepasswordaction
        [HttpPost]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> ChangePasswordAction(PasswordVM passwordVM)
        {
            if (ModelState.IsValid)
            {
                passwordVM.Token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.ChangePassword(passwordVM);
                if (result.IsSuccessed == true)
                {
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.Session.Remove("token_access");
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("ChangePassword", passwordVM);
                }
            }
            return View("ChangePassword", passwordVM);
        }

        // POST user/forgotpasswordaction
        [HttpPost]
        public async Task<IActionResult> ForgotPasswordAction(string Email)
        {
            var result = await _userApiClient.ForgotPassword(Email);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return View("ForgotPassword");
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return View("ForgotPassword");
            }
        }

        // POST user/register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.Register(registerVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError("", result.Message);
                return View(registerVM);
            }
            return View(registerVM);
        }

        // GET user/logout
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("token_access");
            return RedirectToAction("Login", "User");
        }

        // POST user/loginaction
        [HttpPost]
        public async Task<IActionResult> LoginAction(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _userApiClient.Login(loginVM);
                if (string.IsNullOrEmpty(result.Entity))
                {
                    ModelState.AddModelError("", result.Message);
                    return View("Login", loginVM);
                }
                var userPrincipal = this.ValidateToken(result.Entity);
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7),
                    IsPersistent = false
                };

                HttpContext.Session.SetString("token_access", result.Entity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
                return RedirectToAction("index", "home");
            }
            return View("login", loginVM);
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validateToken;
            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters();

            tokenValidationParameters.ValidateLifetime = true;
            tokenValidationParameters.ValidAudience = _configuration["JWT:Audience"];
            tokenValidationParameters.ValidIssuer = _configuration["JWT:Issuer"];
            tokenValidationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, tokenValidationParameters, out validateToken);
            return principal;
        }

        // update your info
        // POST user/update
        [HttpPost]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> UpdateInfo(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.Update(appUserVM, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return Redirect("/user/logout");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View("info",appUserVM);
                }
            }
            else
                return View("info",appUserVM);
        }

        // update info of users by Admin
        // POST user/updateusersaction
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateUsersAction(AppUserModelMVC appUserModelMVC)
        {
            string token = HttpContext.Session.GetString("token_access");
            if (ModelState.IsValid)
            {
                var result = await _userApiClient.UpdateUsers(appUserModelMVC, token);
                if (result.IsSuccessed == true)
                {
                    TempData["SuccessResult"] = result.Entity;
                    return Redirect("/user/getall");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    var list = await _userRoleServiceApiClient.GetAll(token);
                    appUserModelMVC.ListAppUserRoleVM = list;
                    return View("UpdateUsers", appUserModelMVC);
                }
            }
            else
            {
                var list = await _userRoleServiceApiClient.GetAll(token);
                appUserModelMVC.ListAppUserRoleVM = list;
                return View("UpdateUsers", appUserModelMVC);
            }
        }

        // GET user/getall
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _userApiClient.GetAll(token);
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

        // GET user/getbyid
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var appUser = await _userApiClient.GetById(id, token);
                return View(appUser);
            }
            return BadRequest("Error 400");
        }

        // GET user/deleteaction
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAction(int id)
        {
            string token = HttpContext.Session.GetString("token_access");
            var result = await _userApiClient.Delete(id, token);
            if (result.IsSuccessed == true)
            {
                TempData["SuccessResult"] = result.Entity;
                return RedirectToAction("GetAll", "user");
            }
            else
            {
                TempData["ErrorResult"] = result.Message;
                return RedirectToAction("GetAll", "user");
            }
        }
    }
}
