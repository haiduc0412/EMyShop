using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Common
{
    public class APISuccessResult<T> : APIResult<T>
    {
        private string v;

        public APISuccessResult(T resultObj)
        {
            IsSuccessed = true;
            ResultObj = resultObj;
        }

        public APISuccessResult()
        {
            IsSuccessed = true;
        }
    }
}
