using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC.Service.Interface
{
    public interface ICustomerServiceApiClient : IServiceApiClient<CustomerVM>
    {
        Task<List<CustomerVM>> GetAllNotDelete(string token);
        Task<List<CustomerVM>> Search(string token, string name, string phone, string email, string address, string city, string country);
    }
}
