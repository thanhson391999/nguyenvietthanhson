using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.ProductImages;
using Microsoft.AspNetCore.Authorization;
using eShopSolution.Application.Catalog.Products.Interfaces;
using eShopSolution.ViewModels.Catalog.Products;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/products/paging/vi-VN?PageIndex=1&PageSize=10&CategoryId=
        [HttpGet("paging/{languageId}")]
        public async Task<PagedResult<ProductViewModel>> GetAllPagingByCategoryId(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var pagedResult = await _productService.GetAllPagingByCategoryId(languageId, request);
            return pagedResult;
        }

        // GET: api/products/1/vi-VN
        [HttpGet("{productId}/{languageId}")]
        public async Task<ProductViewModel> GetById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            return product;
        }

        // POST: api/products
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();
            var product = await _productService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { productId = productId }, product);
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _productService.Update(id, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // DELETE: api/products/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var result = await _productService.Delete(productId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // PATCH: api/products/1/newprice/10000
        [HttpPatch("{productId}/newprice/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _productService.UpdatePrice(productId, newPrice);
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
            var productImageId = await _productService.AddImage(productId, request);
            if (productImageId == 0)
                return BadRequest();
            var productImage = await _productService.GetByIdImage(productImageId);
            return CreatedAtAction(nameof(GetByIdImage), new { productImageId = productImageId }, productImage);
        }

        // PUT: api/products/1/images/1
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _productService.UpdateImage(imageId, request);
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
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        // GET: api/products/1/images/1
        [HttpGet("{productId}/images/{productImageId}")]
        public async Task<ProductImageViewModel> GetByIdImage(int productImageId)
        {
            var productImage = await _productService.GetByIdImage(productImageId);
            return productImage;
        }
    }
}