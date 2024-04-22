using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CongThongTin.Models
{
    public partial class Package_Cate
    {
        public Package_Cate()
        {
            Package = new HashSet<Package>();
        }
        [Key]
        [StringLength(20)]
        [Display(Name = "Loại gói cước")]
        public string Package_CateID { get; set; }
        [StringLength(20)]
        [NotNull]
        [Display(Name = "Tên loại")]
        public string Package_name { get; set; }
        //Khóa ngoại PackageCate-Package
        [InverseProperty("PackageCateIDNavigation")]
        public virtual ICollection<Package> Package { get; set; }
    }
}
