using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Product.Public
{
    public class PublicGetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}