using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMyShop.ApiIntegration;
using EMyShop.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMyShop.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductsController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }
        //public async Task<IActionResult> Detail(int id, string culture)
        //{
        //    var product = await _productApiClient.GetById(id, culture);
        //    return View(new ProductDetailViewModel()
        //    {
        //        Product = product
        //    });
        //}

        //public async Task<IActionResult> Category(int id, string culture, int page = 1)
        //{
        //    var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
        //    {
        //        CategoryId = id,
        //        PageIndex = page,
        //        LanguageId = culture,
        //        PageSize = 10
        //    });
        //    return View(new ProductCategoryViewModel()
        //    {
        //        Category = await _categoryApiClient.GetById(culture, id),
        //        Products = products
        //    }); ;
        //}
    }
}