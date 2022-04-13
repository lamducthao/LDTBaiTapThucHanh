using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LDTBaiTapThucHanh.Models
{
    public class KhachHang
    {
        [Key]
        [Required(ErrorMessage = "Ten khach hangkhong duoc de trong")]
        public string TenKH { get; set; }
        [Required]
        public string MaKH { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sdt { get; set; }
    }
}