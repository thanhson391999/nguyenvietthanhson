﻿using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<AppRole> _roleManager;

        public UserService(UserManager<AppUser> userManager,
                           SignInManager<AppUser> signInManager,
                           IConfiguration configuration,
                           RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request)
        {
            // Select
            var users = _userManager.Users;
            // Filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                users = users.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword));
            }
            // Paging
            var totalRecord = await users.CountAsync();
            var data = await users.Skip((request.PageIndex - 1) * request.PageSize)
                            .Take(request.PageSize)
                            .Select(x => new UserViewModel()
                            {
                                FirstName = x.FirstName,
                                Email = x.Email,
                                Id = x.Id,
                                LastName = x.LastName,
                                PhoneNumber = x.PhoneNumber,
                                UserName = x.UserName
                            }).ToListAsync();
            // Select and projection
            var pageResult = new PagedResult<UserViewModel>()
            {
                Items = data,
                TotalRecord = totalRecord
            };
            return pageResult;
        }

        public async Task<ApiResult<string>> Login(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return new ApiErrorResult<string>("Tên đăng nhập không tồn tại");
            }
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Mật khẩu không đúng");
            }
            var token = GenarateToken(user);
            return new ApiSuccessResult<string>(token);
        }

        public async Task<ApiResult<string>> Register(RegisterRequest request)
        {
            var userName = await _userManager.FindByNameAsync(request.UserName);
            if (userName != null)
            {
                return new ApiErrorResult<string>("Tên đăng nhập đã tồn tại");
            }
            var email = await _userManager.FindByEmailAsync(request.Email);
            if (email != null)
            {
                return new ApiErrorResult<string>("Email đã tồn tại");
            }
            var user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                UserName = request.UserName
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Đăng ký không thành công");
            }
            return new ApiSuccessResult<string>("Đăng ký thành công");
        }

        private string GenarateToken(AppUser user)
        {
            var issuer = _configuration["JWT:Issuer"];
            var audience = _configuration["JWT:Audience"];
            var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
            var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
            var roles = _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName+" "+user.LastName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}