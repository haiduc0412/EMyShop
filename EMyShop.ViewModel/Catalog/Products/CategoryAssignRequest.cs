using System;
using System.Collections.Generic;
using System.Text;
using EMyShop.ViewModel.Common;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItems> Categories { get; set; } = new List<SelectItems>();
    }
}
