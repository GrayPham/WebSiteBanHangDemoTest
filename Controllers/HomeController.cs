using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: Home
        public ActionResult Index()
        {
            //List điện thoại mới nhất
            var lstDTM = db.SanPhams.Where(n => n.MaLoaiSP == 1 && n.Moi == 1 && n.DaXoa == false);
            // Gán vào  ViewBag
            ViewBag.ListDTM = lstDTM;
            var lstLTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1 && n.DaXoa == false);
            // Gán vào  ViewBag
            ViewBag.ListLTM = lstLTM;
            var lstMTM = db.SanPhams.Where(n => n.MaLoaiSP == 3 && n.Moi == 1 && n.DaXoa == false);
            // Gán vào  ViewBag
            ViewBag.ListMTM = lstMTM;
            return View();
        }
        [ChildActionOnly]
        public ActionResult MenuPartial()
        {
            var lstSP = db.SanPhams;
            return PartialView(lstSP);
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult DangKy(FormCollection f)
        {
            return View();
        }
    }
}