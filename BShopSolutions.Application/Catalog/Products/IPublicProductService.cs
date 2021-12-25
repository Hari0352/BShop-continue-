using BShopSolution.ViewModels.Catalog.Products;
using BShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BShopSolutions.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
