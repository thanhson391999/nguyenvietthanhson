using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Interfaces.Manage
{
    public interface IManageProductService
    {
        Task<int> Create(ManageProductCreateRequest productCreateRequest);

        Task<int> Update(int id, ManageProductUpdateRequest productEditRequest);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(ManageGetProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest productImageCreateRequest);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest productImageUpdateRequest);

        Task<List<ProductImageViewModel>> GetAllImage(int productId);

        Task<ProductImageViewModel> GetByIdImage(int imageId);
    }
}