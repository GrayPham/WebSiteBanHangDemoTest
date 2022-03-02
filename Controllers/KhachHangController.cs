using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult Index()
        {
            //TruyVan Du lieu thong qua cau lenh
            
            var lstKH = from KH in db.KhachHangs select KH;

            return View(lstKH);
        }
        public ActionResult Index1()
        {
            var lstKH = from KH in db.KhachHangs select KH;

            return View(lstKH);
        }
        public ActionResult TruyVan1DoiTuong()
        {
            ////Truy Van 1 doi tuong bang cau lenh truy Van 
            //var lstKH = from kh in db.KhachHangs where kh.MaKH==1 select kh;
            //KhachHang khach = lstKH.FirstOrDefault();

            KhachHang khach = db.KhachHangs.SingleOrDefault(n => n.MaKH == 1);
            return View(khach);
        }
        public ActionResult SortDuLieu()
        {
            List<KhachHang> lstKH = db.KhachHangs.OrderByDescending(n => n.MaKH).ToList();
            return View(lstKH);
        }
        public ActionResult GroupDuLieu()
        {
            List<ThanhVien> lstKH = db.ThanhViens.OrderByDescending(n => n.TaiKhoan).ToList();
            return View(lstKH);
        }
    }
}