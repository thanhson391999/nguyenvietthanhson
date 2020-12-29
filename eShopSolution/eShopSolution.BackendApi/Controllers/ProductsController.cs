using eShopSolution.Application.Catalog.Products.Interfaces.Public;
using eShopSolution.Application.Catalog.Products.Interfaces.Manage;
using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Public;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using eShopSolution.ViewModels.Catalog.ProductImages;

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
        public async Task<PagedResult<ProductViewModel>> GetAllPaging(string languageId, [FromQuery] PublicGetProductPagingRequest request)
        {
            var productPR = await _publicProductService.GetAllPaging(languageId, request);
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
        public async Task<IActionResult> Create([FromForm] ManageProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
                return BadRequest();
            var product = await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { productId = productId }, product);
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm] ManageProductUpdateRequest request, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _manageProductService.Update(id, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // DELETE: api/products/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var result = await _manageProductService.Delete(productId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // PATCH: api/products/1/newprice/10000
        [HttpPatch("{productId}/newprice/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _manageProductService.UpdatePrice(productId, newPrice);
            if (result == false)
                return BadRequest();
            return Ok();
        }

        // POST: api/products/1/images
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var productImageId = await _manageProductService.AddImage(productId, request);
            if (productImageId == 0)
                return BadRequest();
            var productImage = await _manageProductService.GetByIdImage(productImageId);
            return CreatedAtAction(nameof(GetByIdImage), new { productImageId = productImageId }, productImage);
        }

        // PUT: api/products/1/images/1
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _manageProductService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // DELETE: api/products/1/images/1
        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int imageId)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _manageProductService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // GET: api/products/1/images/1
        [HttpGet("{productId}/images/{productImageId}")]
        public async Task<ProductImageViewModel> GetByIdImage(int productImageId)
        {
            var productImage = await _manageProductService.GetByIdImage(productImageId);
            return productImage;
        }
    }
}