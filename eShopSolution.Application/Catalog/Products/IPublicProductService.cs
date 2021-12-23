using BShopSolution.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
