using eShopSolutions.Application.Catalog.Products.Dtos;
using eShopSolutions.Application.Catalog.Products.Dtos.Public;
using eShopSolutions.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutions.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public PagedViewModel<ProductViewModel> GetALlByCategoryId(GetProductPagingRequest request);
    }
}
