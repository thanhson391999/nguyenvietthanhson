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

        [Authorize(Roles = "Admin,Users")]
        public IActionResult Info()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Users")]
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

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [Authorize(Roles = "Admin,Users")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> ChangePasswordAction(PasswordVM passwordVM)
        {
            if (ModelState.IsValid)
            {
                passwordVM.Token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.ChangePassword(passwordVM);
                if (result)
                {
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.Session.Remove("token_access");
                    return RedirectToAction("Login", "User");
                }
                else
                    return Ok("Password changed fail");
            }
            return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPasswordAction(string Email)
        {
            if (ModelState.IsValid)
            {
                var result = await _userApiClient.ForgotPassword(Email);
                if (result)
                {
                    return Ok("Email To reset password have sent to your Email. Check it out!");
                }
                else
                    return Ok("Can't send email !");
            }
            return BadRequest("Error 400");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.Register(registerVM, token);
                if (result)
                {
                    return RedirectToAction("Login", "User");
                }
                return Ok("Register fail");
            }
            return BadRequest("Error 400");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("token_access");
            return RedirectToAction("Login", "User");
        }

        [HttpPost]
        public async Task<IActionResult> LoginAction(LoginVM loginVM)
        {
            string token = await _userApiClient.Login(loginVM);
            if (token == "")
            {
                return Redirect("/user/login");
            }
            var userPrincipal = this.ValidateToken(token);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7),
                IsPersistent = false
            };

            HttpContext.Session.SetString("token_access", token);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            return RedirectToAction("index", "home");
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
        [HttpPost]
        [Authorize(Roles = "Admin,Users")]
        public async Task<IActionResult> Update(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.Update(appUserVM, token);
                if (result)
                {

                    return Redirect("/user/logout");
                }
                else
                    return BadRequest("Can't Update");
            }
            else
                return BadRequest("Error 400");
        }

        // update info of users by Admin
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateUsersAction(AppUserModelMVC appUserModelMVC)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.UpdateUsers(appUserModelMVC, token);
                if (result)
                {
                    return Redirect("/user/getall");
                }
                else
                    return BadRequest("Can't Update");
            }
            else
                return BadRequest("Error 400");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var list = await _userApiClient.GetAll(token);
                return View(list);
            }
            return BadRequest("Error 400");
        }

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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAction(int id)
        {
            if (ModelState.IsValid)
            {
                string token = HttpContext.Session.GetString("token_access");
                var result = await _userApiClient.Delete(id, token);
                if (result)
                {
                    return RedirectToAction("GetAll", "user");
                }
                else
                    return BadRequest("Delete Fail !");
            }
            else
                return BadRequest("Error 400");
        }
    }
}
