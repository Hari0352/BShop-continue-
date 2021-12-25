using BShopSolution.Application.Catalog.Products.Dtos;
using BShopSolution.Application.Catalog.Products.Dtos.Public;
using BShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
