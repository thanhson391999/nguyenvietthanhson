using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Service
{
    public interface IUserApiClient
    {
        Task<string> Login(LoginRequest loginRequest);

        Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest getUserPagingRequest);

        Task<bool> Register(RegisterRequest registerRequest);
    }
}