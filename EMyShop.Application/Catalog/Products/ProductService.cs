using EMyShop.Application.Catalog.Common;
using EMyShop.Data.EF;
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
    public class ProductService : IProductsService
    {
        private readonly EShopDBContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        public ProductService(EShopDBContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> Create(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int productId, string languageId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }

        public Task AddViewcount(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<ProductVM>> GetAllPaging(GetManageProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImage(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageVM> GetImageById(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductImageVM>> GetListImages(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<ProductVM>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<APIResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductVM>> GetFeaturedProducts(string languageId, int take)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductVM>> GetLatestProducts(string languageId, int take)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<ProductVM>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
