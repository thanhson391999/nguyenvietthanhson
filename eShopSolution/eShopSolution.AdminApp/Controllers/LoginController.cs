using eShopSolution.AdminApp.Service;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUserApiClient _userApiClient;

        public LoginController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _userApiClient = userApiClient;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IndexAction(LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            var token = await _userApiClient.Login(request);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            HttpContext.Session.SetString("Token", token);
            var userPrincipal = this.ValidateToken(token);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7),
                // Lưu phiên đăng nhập
                IsPersistent = false
            };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            return RedirectToAction("Index", "Home");
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
    }
}