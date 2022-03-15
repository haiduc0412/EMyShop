using EMyShop.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class ProductVM
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public decimal Price { set; get; }
        public string Image { set; get; }
        public Status Status { set; get; }
        public int? Warranty { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int CategoryID { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string Description { get; set; }
    }
}
