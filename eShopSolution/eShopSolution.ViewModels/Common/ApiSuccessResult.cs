using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T entity)
        {
            IsSuccessed = true;
            Entity = entity;
        }

        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}