using EMyShop.Data.Entities;
using EMyShop.ViewModel.Catalog.Products;
using EMyShop.ViewModel.Catalog.ProductImage;
using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMyShop.Application.Catalog.Products
{
    public interface IProductsService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<Product> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PageResult<ProductVM>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageVM> GetImageById(int imageId);

        Task<List<ProductImageVM>> GetListImages(int productId);

        Task<PageResult<ProductVM>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<APIResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<List<ProductVM>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductVM>> GetLatestProducts(string languageId, int take);

    }
}
