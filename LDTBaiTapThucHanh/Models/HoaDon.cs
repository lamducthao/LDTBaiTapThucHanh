using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LDTBaiTapThucHanh.Models
{
    public class HoaDon
    {
        [Key]
        public string TenSp { get; set; }
        [Required]
        public string GiaTien { get; set; }
        [Required]
        public string SoLUONG { get; set; }
    }
}