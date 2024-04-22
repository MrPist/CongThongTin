using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.Options;
using System.Diagnostics.CodeAnalysis;
using System;

namespace CongThongTin.Models
{
    public partial class Post
    {
        [Key]
        [StringLength(50)]
        [Display(Name ="ID")]
        public string PostID { get; set; }
        [StringLength(50)]
        [Display(Name ="Thể loại tin")]
        public string PostCateID { get; set; }
        [StringLength(250)]
        [Display(Name = "Tiêu đề")]
        public string Post_title { get; set; }
        [Display(Name ="Nội dung")]
        public string Post_content { get; set; }
        //[AllowNull]
        //[Display(Name = "Đoạn 2")]
        //public string Post_content2 { get; set; }
        //[AllowNull]
        //[Display(Name = "Đoạn 3")]
        //public string Post_content3 { get; set; }
        //[AllowNull]
        //[Display(Name = "Đoạn 4")]
        //public string Post_content4 { get; set; }
        [Display(Name = "Hình nền")]
        public string? avatar { get; set; }
        //[AllowNull]
        //[StringLength(255)]
        //[Display(Name = "Ảnh 1")]
        //public string img1 { get; set; }
        //[AllowNull]
        //[StringLength(255)]
        //[Display(Name = "Ảnh 2")]
        //public string img2 { get; set; }
        //[AllowNull]
        //[StringLength(255)]
        //[Display(Name = "Ảnh 3")]
        //public string img3 { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime Date_created { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime Date_update { get; set; }

        // --- khóa ngoại PostCate-Post
        [ForeignKey(nameof(PostCateID))]
        [InverseProperty(nameof(Post_cate.Post))]
        public virtual Post_cate PostIDNavigation { get; set; }
        //[NotMapped]
        //public IFormFile ImageUpload1 { get; set; }
        //[NotMapped]
        //public IFormFile ImageUpload2 { get; set; }
        //[NotMapped]
        //public IFormFile ImageUpload3 { get; set; }

    }
}
