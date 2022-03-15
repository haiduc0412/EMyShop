using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Common
{
    public class APIResult<T>
    {
        public bool IsSuccessed { get; set; }

        public string Message { get; set; }

        public T ResultObj { get; set; }
    }
}
