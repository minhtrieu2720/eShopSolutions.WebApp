using eShopSolutions.ViewModels.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutions.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryId { get; set; }
    }
}
