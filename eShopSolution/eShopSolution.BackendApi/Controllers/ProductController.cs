using eShopSolution.Application.Catalog.Products.Interfaces.Manage;
using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Manage;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IManageProductService _manageProductService;
        public ProductController(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }

        // GET: api/product
        [HttpGet]
        public async Task<PagedResult<ProductViewModel>> GetAllPaging(ManageGetProductPagingRequest request)
        {
            return await _manageProductService.GetAllPaging(request);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
