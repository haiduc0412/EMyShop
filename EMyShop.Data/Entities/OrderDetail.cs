using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMyShop.Data.Entities
{
    [Table("Orderdetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public int OrderID { set; get; }

        [Required]
        public int ProductID { set; get; }

        public decimal Price { set; get; }

        public int Quantitty { set; get; }

        public decimal Amount { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}