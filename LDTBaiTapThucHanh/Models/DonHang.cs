using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LDTBaiTapThucHanh.Models
{
    public class DonHang
    {
        [Key]
        public string ThemSP { get; set; }
        [Required]
        public string XoaSP { get; set; }
    }
}