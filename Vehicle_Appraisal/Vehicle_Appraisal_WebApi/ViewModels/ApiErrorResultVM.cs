using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class ApiErrorResultVM<T> : ApiResultVM<T>
    {
        public ApiErrorResultVM(string message)
        {
            IsSuccessed = false;
            Message = message;
        }
    }
}
