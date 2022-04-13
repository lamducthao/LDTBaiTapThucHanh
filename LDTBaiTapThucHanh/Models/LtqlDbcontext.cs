using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LDTBaiTapThucHanh.Models
{
    public partial class LtqlDbcontext : DbContext  
    {
        public LtqlDbcontext() : base("name=LtqlDbcontext") { }
        
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
    }
}