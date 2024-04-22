using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongThongTin.Models
{
    public partial class Post_cate
    {
        public Post_cate()
        {
            Package = new HashSet<Package>();
            Phone_number = new HashSet<Phone_number>();
            Post = new HashSet<Post>();
        }
        [Key]
        [StringLength(50)]
        [Display(Name ="Thể loại tin")]
        public string PostCateID { get; set; }
        [StringLength(100)]
        [Display(Name ="Tên loại")]
        public string Name { get; set; }
        [StringLength(150)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        // --- Khóa ngoại Postcate-Post
        [InverseProperty("PostIDNavigation")]
        public virtual ICollection<Post> Post { get; set; }

        // --- Khóa ngoại Postcate-Phone_number
        [InverseProperty("Phone_numberIDNavigation")]
        public virtual ICollection<Phone_number> Phone_number { get; set; }

        // --- Khóa ngoại Postcate-Package
        [InverseProperty("PackageIDNavigation")]
        public virtual ICollection<Package> Package { get; set; }
    }
}
