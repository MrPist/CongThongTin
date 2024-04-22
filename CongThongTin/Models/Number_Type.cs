using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CongThongTin.Models
{
    public partial class Number_Type
    {
        public Number_Type()
        {
            Phone_number = new HashSet<Phone_number>();
        }
        [Key]
        [StringLength(50)]
        [Display(Name = "Loại số")]
        public string Number_TypeID { get; set; }
        [StringLength(100)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [StringLength(150)]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [StringLength (20)]
        [Display(Name = "Giá")]
        public string cost { get; set; }
        // --- Khóa ngoại Number_Type-Phone_number
        [InverseProperty("Number_TypeIDNavigation")]
        public virtual ICollection<Phone_number> Phone_number { get; set; }
    }
}
