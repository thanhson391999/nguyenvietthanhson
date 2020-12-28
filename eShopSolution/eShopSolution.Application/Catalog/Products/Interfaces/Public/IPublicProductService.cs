﻿using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Public;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Interfaces.Public
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(PublicGetProductPagingRequest request);
    }
}
