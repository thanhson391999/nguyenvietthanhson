using System;

namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class PaginationVM
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; } = 3;
        public int TotalRecord { get; set; }
        public int PageCount
        {
            get
            {
                var pageCount = (double)TotalRecord / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}
