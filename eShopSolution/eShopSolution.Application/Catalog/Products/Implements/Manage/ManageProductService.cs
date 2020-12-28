using eShopSolution.Application.Catalog.Products.Interfaces.Manage;
using eShopSolution.Application.Common;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Catalog;
using eShopSolution.ViewModels.Catalog.Product.Manage;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products.Implements.Manage
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _fileStorageService;
        public ManageProductService(EShopDbContext context, IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
            _context = context;
        }

        public async Task<int> AddImages(int productId, List<IFormFile> files)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null || files.Count() < 1)
            {
                throw new ArgumentNullException();
            }
            int i = 1;
            foreach (var item in files)
            {
                var productImage = new ProductImage()
                {
                    Caption = "Thumbnail Image",
                    DateCreated = DateTime.Now,
                    IsDefault = false,
                    SortOrder = i++,
                    FileSize = item.Length,
                    ImagePath = await this.SaveFile(item),
                    ProductId = product.Id
                };
                _context.ProductImages.Add(productImage);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task AddViewcount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ManageProductCreateRequest request)
        {
            var product = new Product()
            {
                OriginalPrice = request.OriginalPrice,
                Price = request.Price,
                Stock = request.Stock,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };
            // Save File
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "Thumbnail Image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }
            _context.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            var thumbnailImage = await _context.ProductImages.Where(x => x.ProductId.Equals(productId)).ToListAsync();
            foreach (var item in thumbnailImage)
            {
                await _fileStorageService.DeleteFileAsync(item.ImagePath);
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(ManageGetProductPagingRequest request)
        {
            // Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };
            // Filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            }
            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(x => request.CategoryIds.Contains(x.pic.CategoryId));
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

        public async Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            var data = await _context.ProductImages.Where(x => x.ProductId == productId).ToListAsync();
            var productImageViewModels = data.Select(x => new ProductImageViewModel()
            {
                Id = x.Id,
                FilePath = x.ImagePath,
                FileSize = x.FileSize,
                IsDefault = x.IsDefault
            }).ToList();
            return productImageViewModels;
        }

        public async Task<int> RemoveImages(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null)
            {
                throw new ArgumentNullException();
            }
            _context.ProductImages.Remove(image);
            await _fileStorageService.DeleteFileAsync(image.ImagePath);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(int id, ManageProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(id);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId.Equals(product.Id) && x.LanguageId.Equals(request.LanguageId));
            if (product == null || productTranslation == null)
            {
                throw new ArgumentNullException();
            }
            productTranslation.Name = request.Name;
            productTranslation.Description = request.Description;
            productTranslation.Details = request.Details;
            productTranslation.SeoAlias = request.SeoAlias;
            productTranslation.SeoDescription = request.SeoDescription;
            productTranslation.SeoTitle = request.SeoTitle;
            // Save File
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(x => x.IsDefault == true && x.ProductId == id);
                thumbnailImage.FileSize = request.ThumbnailImage.Length;
                thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                _context.ProductImages.Update(thumbnailImage);
            }
            _context.ProductTranslations.Update(productTranslation);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImages(int imageId, string caption, IFormFile file)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null || file == null)
            {
                throw new ArgumentNullException();
            }
            image.Caption = caption;
            image.ImagePath = await this.SaveFile(file);
            _context.ProductImages.Update(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return false;
            }
            product.Price = newPrice;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return false;
            }
            product.Stock = addedQuantity;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return true;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _fileStorageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
