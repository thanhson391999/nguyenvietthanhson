using eShopSolution.ViewModels.Common;
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
        Task<ApiResult<string>> Login(LoginRequest loginRequest);

        Task<ApiResult<string>> Register(RegisterRequest registerRequest);

        Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest getUserPagingRequest);

        Task<ApiResult<string>> Update(Guid id, UserUpdateRequest userUpdateRequest);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<string>> Delete(Guid id);
    }
}