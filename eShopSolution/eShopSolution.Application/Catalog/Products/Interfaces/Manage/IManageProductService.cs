using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Manage;
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
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(ManageGetProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, string caption, IFormFile file);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
