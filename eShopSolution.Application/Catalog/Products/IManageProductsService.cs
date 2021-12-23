using BShopSolution.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BShopSolution.Application.Catalog.Products
{
    public interface IManageProductsService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductEditRequest request);

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PageViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
