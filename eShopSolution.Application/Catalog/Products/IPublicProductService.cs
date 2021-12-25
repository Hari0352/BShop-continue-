using BShopSolution.ViewModels.Catalog.Products;
using BShopSolution.ViewModels.Catalog.Products.Public;
using BShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace BShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
