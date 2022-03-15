using EMyShop.ViewModel.Catalog.Products;
using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMyShop.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductVM>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<APIResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVM> GetById(int id, string languageId);

        Task<List<ProductVM>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductVM>> GetLatestProducts(string languageId, int take);

        Task<bool> DeleteProduct(int id);
    }
}
