using eShopSolution.Application.Catalog.Products.Interfaces.Public;
using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Public;
using eShopSolution.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Implements.Public
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EShopDbContext _context;
        public PublicProductService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, PublicGetProductPagingRequest request)
        {
            // Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic };
            // Filter
            if (request.CategoryId > 0)
            {
                query = query.Where(x => x.pic.CategoryId.Equals(request.CategoryId));
            }
            // Paging
            var totalRecord = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                                  .Take(request.PageSize)
                                  .Select(x => new ProductViewModel()
                                  {
                                      Id = x.p.Id,
                                      Name = x.pt.Name,
                                      DateCreated = x.p.DateCreated,
                                      Description = x.pt.Description,
                                      Details = x.pt.Details,
                                      LanguageId = x.pt.LanguageId,
                                      OriginalPrice = x.p.OriginalPrice,
                                      Price = x.p.Price,
                                      SeoAlias = x.pt.SeoAlias,
                                      SeoDescription = x.pt.SeoDescription,
                                      SeoTitle = x.pt.SeoTitle,
                                      Stock = x.p.Stock,
                                      ViewCount = x.p.ViewCount
                                  }).ToListAsync();
            // Select and projection
            var pageResult = new PagedResult<ProductViewModel>()
            {
                Items = data,
                TotalRecord = totalRecord
            };
            return pageResult;
        }
    }
}
