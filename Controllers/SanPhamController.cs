using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: SanPham
        [ChildActionOnly]
        public ActionResult SanPhamStyle1Partial()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult SanPhamStyle2Partial()
        {
            return PartialView();
        }
        // Xây dựng trang xem chi tiết
        public ActionResult XemChiTiet(int? id, string tensp)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sp = db.SanPhams.SingleOrDefault(n => n.MaSP == id && n.DaXoa == false);
            if(sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
        //Xay dung 1 action load san pham theo mã loại sản phẩm và mã nhà sản phẩm
        public ActionResult SanPham(int? MaLoaiSP, int? MaNSX, string TenNSX)
        {
            if (MaLoaiSP == null || MaNSX == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var lstSP = db.SanPhams.Where(n => n.MaLoaiSP == MaLoaiSP && n.MaNSX== MaNSX);
            if (lstSP.Count() == 0)
            {
                return HttpNotFound();
            }
            return View(lstSP);
        }

    }
}