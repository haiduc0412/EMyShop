using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using EMyShop.Data.Enum;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public string Description { set; get; }
        public string CreatedBy { set; get; }
        public Status Status { set; get; }
        public int? Warranty { set; get; }
    }
}
