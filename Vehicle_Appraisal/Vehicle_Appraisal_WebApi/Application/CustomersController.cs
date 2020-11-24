using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;

        public CustomersController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }

        [HttpGet]
        public async Task<List<CustomerVM>> GetAll()
        {
            return await _CustomerService.GetAll();
        }

        [HttpGet("not-delete")]
        public async Task<List<CustomerVM>> GetAllNotDelete()
        {
            return await _CustomerService.GetAllNotDelete();
        }

        [HttpGet("{id}")]
        public async Task<CustomerVM> GetById(int id)
        {
            return await _CustomerService.GetById(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _CustomerService.Delete(id);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Delete Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Delete Fail !",
                is_erro = true,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CustomerVM CustomerVM)
        {
            var result = await _CustomerService.Insert(CustomerVM);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Insert Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Insert Fail !",
                is_erro = true,
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CustomerVM CustomerVM, int id)
        {
            var result = await _CustomerService.Update(CustomerVM, id);
            if (result == true)
            {
                return Ok(new
                {
                    message = "Update Success !",
                    is_erro = false,
                });
            }
            return BadRequest(new
            {
                message = "Update Fail !",
                is_erro = true,
            });
        }

        [HttpGet("info")]
        public async Task<List<CustomerVM>> Search(string name, string phone, string email, string address, string city, string country)
        {
            return await _CustomerService.Search(name, phone, email, address, city, country);
        }

    }
}
