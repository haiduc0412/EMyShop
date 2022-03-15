using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Common
{
    public class APIErrorResult<T> : APIResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public APIErrorResult()
        {
        }

        public APIErrorResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

        public APIErrorResult(string[] validationErrors)
        {
            IsSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}
