﻿using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Login(LoginRequest loginRequest);

        Task<bool> Register(RegisterRequest registerRequest);

        Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest getUserPagingRequest);
    }
}