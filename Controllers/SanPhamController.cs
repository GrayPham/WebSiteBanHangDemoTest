using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    
    public class SanPhamController : Controller
    {
        // GET: SanPham
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult SanPham1()
        {
            var lstSanPhamMoi = db.SanPhams.Where(n => n.Moi == 1);

            ViewBag.ListSP = lstSanPhamMoi;
            var lstSanPhamDienThoai = db.SanPhams.Where(n => n.MaLoaiSP == 1 );
            ViewBag.ListDT = lstSanPhamDienThoai;
            return View();
        }
        public ActionResult SanPham2()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult SanPhamPartial()
        {
            

            return PartialView();
        }
    }
}