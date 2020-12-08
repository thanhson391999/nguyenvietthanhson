using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class PaginationSearchVM : PaginationVM
    {
        public string keyWord { get; set; }
        public string subjects { get; set; }
    }
}
