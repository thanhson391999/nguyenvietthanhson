using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService
{
    public interface ICustomerService : IService<CustomerVM>
    {
        Task<List<CustomerVM>> GetAllNotDelete();
        Task<List<CustomerVM>> Search(string name, string phone, string email, string address, string city, string country);
    }
}
