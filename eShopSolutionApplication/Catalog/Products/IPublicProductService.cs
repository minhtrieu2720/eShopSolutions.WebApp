using eShopSolutions.ViewModels.Catalog.Common;
using eShopSolutions.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutions.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedViewModel<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
