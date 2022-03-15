using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.System.User
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
