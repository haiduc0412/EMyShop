using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> categoryid { get; set; }
    }
}
