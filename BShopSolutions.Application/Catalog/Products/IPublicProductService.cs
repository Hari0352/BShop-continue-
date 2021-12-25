using BShopSolution.ViewModels.Catalog.Products;
using BShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace BShopSolutions.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
    }
}
