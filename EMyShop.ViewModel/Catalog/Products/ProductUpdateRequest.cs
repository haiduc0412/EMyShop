using EMyShop.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int ID { get; set; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public string Description { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public Status Status { set; get; }
        public int? Warranty { set; get; }
    }
}
