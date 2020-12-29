using eShopSolution.Application.Catalog.Products.Interfaces.Public;
using eShopSolution.Application.Catalog.Products.Interfaces.Manage;
using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Public;
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
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
            _publicProductService = publicProductService;
        }

        // GET: api/products/vi-VN?PageIndex=1&PageSize=10&CategoryId=
        [HttpGet("{languageId}")]
        public async Task<PagedResult<ProductViewModel>> GetAllPagingByCategoryId(string languageId, [FromQuery]PublicGetProductPagingRequest request)
        {
            var productPR = await _publicProductService.GetAllByCategoryId(languageId, request);
            return productPR;
        }

        // GET: api/products/1/vi-VN
        [HttpGet("{productId}/{languageId}")]
        public async Task<ProductViewModel> GetById(int productId, string languageId)
        {
            var product = await _manageProductService.GetById(productId, languageId);
            return product;
        }

        // POST: api/products
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ManageProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var product = await _manageProductService.Create(request);
            if (product == 0)
                return BadRequest();
            return Ok(product);
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm]ManageProductUpdateRequest request, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var product = await _manageProductService.Update(id, request);
            if (product == 0)
                return BadRequest();
            return Ok(product);
        }

        // DELETE: api/products/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var product = await _manageProductService.Delete(productId);
            if (product == 0)
                return BadRequest();
            return Ok(product);
        }

        // PATCH: api/products/1/newprice/10000
        [HttpPatch("{productId}/newprice/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _manageProductService.UpdatePrice(productId, newPrice);
            if (product == false)
                return BadRequest();
            return Ok(product);
        }
    }
}
