using System.Collections.Generic;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class PageResultVM<T> : PaginationVM
    {
        public List<T> Items { get; set; }
    }
}
