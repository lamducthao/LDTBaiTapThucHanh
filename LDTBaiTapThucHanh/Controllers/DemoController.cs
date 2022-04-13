using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LDTBaiTapThucHanh.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sinhvien()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sinhvien(string Masinhvien, string Hoten)
        {
            ViewBag.Thongtin = Masinhvien + " " + Hoten;
            return View();
        }

    }
}