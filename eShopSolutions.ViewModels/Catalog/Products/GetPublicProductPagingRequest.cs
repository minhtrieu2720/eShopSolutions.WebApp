using eShopSolutions.ViewModels.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutions.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
