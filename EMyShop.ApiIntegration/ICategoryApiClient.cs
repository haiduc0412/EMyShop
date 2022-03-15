using EMyShop.ViewModel.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMyShop.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoriesVM>> GetAll(string languageId);

        Task<CategoriesVM> GetById(string languageId, int id);
    }
}
