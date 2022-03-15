using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
