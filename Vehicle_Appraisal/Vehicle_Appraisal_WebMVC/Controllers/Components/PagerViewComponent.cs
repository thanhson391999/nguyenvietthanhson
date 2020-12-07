using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PaginationVM paginationVM)
        {
            return Task.FromResult((IViewComponentResult)View("Default", paginationVM));
        }
    }
}
