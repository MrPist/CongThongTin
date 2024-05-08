using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CongThongTin.Models;

namespace CongThongTin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CongThongTin.Models.Post_cate> Post_cate { get; set; }
        public DbSet<CongThongTin.Models.Post> Post { get; set; }
        public DbSet<CongThongTin.Models.Number_Type> Number_Type { get; set; }
        public DbSet<CongThongTin.Models.Phone_number> Phone_number { get; set; }
        public DbSet<CongThongTin.Models.Package> Package { get; set; }
        public DbSet<CongThongTin.Models.Package_Cate> Package_Cate { get; set; }
        public DbSet<CongThongTin.Models.Cuahang> Cuahang { get; set; }
    }
}
