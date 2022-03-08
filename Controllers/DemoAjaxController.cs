using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class DemoAjaxController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: DemoAjax
        public ActionResult DemoAjax()
        {
            return View();
        }
        // Action link
        public ActionResult LoadAjaxActionLink()
        {
            return Content("Hello Ajax");
        }
        // BeginForm
        [HttpPost]
        public ActionResult LoadAjaxBeginform(FormCollection f)
        {
            string KQ = f["txt1"].ToString();
            return Content(KQ);
        }
        //Xu li Ajax Jquery
        public ActionResult LoadAjaxJQuery(int a , int b)
        {
            return Content((a + b).ToString());
        }

        public ActionResult SanPhamPartial()
        {

            var lstSanPham = db.SanPhams;
            return PartialView(lstSanPham);
        }
    }
}