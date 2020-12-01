using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class ApiResultVM<T>
    {
        public bool IsSuccessed { get; set; }
        public string Message { get; set; }
        public T Entity { get; set; }
    }
}
