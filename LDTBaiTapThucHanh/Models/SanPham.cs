using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LDTBaiTapThucHanh.Models
{
    public class SanPham
    {
        [Key]
        public string TenSp { get; set; }
        [Required]
        public string MaSp { get; set; }
        [Required]
        public string SoLUONG { get; set; }
        [Required]
        public string NgaySanSuat { get; set; }
        
    }
}