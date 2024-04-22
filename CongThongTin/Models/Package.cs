using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Models
{
    public partial class Package
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "Mã gói")]
        public string Package_ID { get; set; }
        [StringLength(100)]
        [Display(Name = "Tiêu đề")]
        public string Package_title { get; set; }
        [StringLength(20)]
        [Display(Name = "Loại gói cước")]
        public string Package_CateID { get; set; }
        [Display(Name = "Thông tin")]
        public string Package_content { get; set; }
        [StringLength(50)]
        [Display(Name = "Thể loại tin")]
        public string PostCateID { get; set; }
        [StringLength(25)]
        [Display(Name = "Giá")]
        public string cost { get; set; }
        [Display(Name = "Đường dẫn")]
        public string link { get; set; }
        // --- khóa ngoại PostCate-Package
        [ForeignKey(nameof(PostCateID))]
        [InverseProperty(nameof(Post_cate.Package))]
        public virtual Post_cate PackageIDNavigation { get; set; }

        //Khóa ngoại PackageCate-Package
        [ForeignKey(nameof(Package_CateID))]
        [InverseProperty(nameof(Package_Cate.Package))]
        public virtual Package_Cate PackageCateIDNavigation { get; set; }
    }
}
