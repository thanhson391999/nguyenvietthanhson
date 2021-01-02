using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Interfaces
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest productCreateRequest);

        Task<int> Update(int id, ProductUpdateRequest productEditRequest);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest productImageCreateRequest);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest productImageUpdateRequest);

        Task<List<ProductImageViewModel>> GetAllImage(int productId);

        Task<ProductImageViewModel> GetByIdImage(int imageId);

        Task<PagedResult<ProductViewModel>> GetAllPagingByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}