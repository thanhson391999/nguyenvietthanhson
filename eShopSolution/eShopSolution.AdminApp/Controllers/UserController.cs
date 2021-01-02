using eShopSolution.AdminApp.Service;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly IUserApiClient _userApiClient;

        public UserController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string Keyword, int PageIndex = 1, int PageSize = 2)
        {
            var token = HttpContext.Session.GetString("Token");
            var request = new GetUserPagingRequest()
            {
                Token = token,
                Keyword = Keyword,
                PageIndex = PageIndex,
                PageSize = PageSize
            };
            var pagedResult = await _userApiClient.GetUsersPaging(request);
            return View(pagedResult);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAction(RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            var result = await _userApiClient.Register(request);
            if (result == true)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}