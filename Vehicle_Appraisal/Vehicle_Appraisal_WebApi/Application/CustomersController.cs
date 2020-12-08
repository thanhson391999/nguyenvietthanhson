using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;

        public CustomersController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }

        // GET api/customers
        [HttpGet]
        [Authorize(Roles = "Admin,Users")]
        public async Task<List<CustomerVM>> GetAll()
        {
            return await _CustomerService.GetAll();
        }

        // GET api/customers/paging
        [HttpGet("paging")]
        [Authorize(Roles = "Admin")]
        public async Task<PageResultVM<CustomerVM>> GetAllPaging([FromQuery] PaginationSearchVM paginationSearchVM)
        {
            return await _CustomerService.GetAllPaging(paginationSearchVM);
        }

        // GET api/customers/not-delete
        [HttpGet("not-delete")]
        [Authorize(Roles = "Admin, Users")]
        public async Task<List<CustomerVM>> GetAllNotDelete()
        {
            return await _CustomerService.GetAllNotDelete();
        }

        // GET api/customers/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<CustomerVM> GetById(int id)
        {
            return await _CustomerService.GetById(id);
        }

        // DELETE api/customers/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _CustomerService.Delete(id);
            return Ok(result);
        }

        // POST api/customers
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Insert(CustomerVM CustomerVM)
        {
            var result = await _CustomerService.Insert(CustomerVM);
            return Ok(result);
        }

        // PUT api/customers/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(CustomerVM CustomerVM, int id)
        {
            var result = await _CustomerService.Update(CustomerVM, id);
            return Ok(result);
        }
    }
}
