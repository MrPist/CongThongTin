using System.ComponentModel.DataAnnotations;

namespace CongThongTin.Models
{
    public partial class Cuahang
    {
        [Key]
        [StringLength(50)]

        [Display(Name ="Mã Cửa hàng")]
        public string MaCH { get; set; }
        [StringLength(150)]
        [Display(Name ="Tên cửa hàng")]
        public string TenCH { get; set; }
        [StringLength(300)]
        [Display(Name ="Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Vị trí")]
        public string? IDmap { get; set; }
    }
}
