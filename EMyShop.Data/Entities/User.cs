using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMyShop.Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { set; get; }

        [Required]
        [MaxLength(50)]
        public string UserName { set; get; }

        [Required]
        [MaxLength(256)]
        public string Password { set; get; }

        [Required]
        [MaxLength(256)]
        public string Fullname { set; get; }

        [MaxLength(10)]
        public string Phone { set; get; }

        [MaxLength(256)]
        public string Email { set; get; }

        public int RoleID { set; get; }

        [MaxLength(10)]
        public string Gender { set; get; }

        public bool Status { set; get; }

        public DateTime CreateAt { set; get; }

        [MaxLength(256)]
        public string Createby { set; get; }

        public DateTime UpdateAt { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [ForeignKey("RoleID")]
        public virtual Role Role { set; get; }
    }
}
