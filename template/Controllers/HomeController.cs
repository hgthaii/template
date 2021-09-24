using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace template.Controllers
{
    public class HomeController : Controller
    {
        WEBweek6Entities db = new WEBweek6Entities();
        public ActionResult Index()
        {
            var sanpham = db.SANPHAMs.Where(sp => sp.DaXoa == false).ToList();
            ViewBag.SanPham = sanpham;
            var consted = db.SANPHAMs.Take(6).ToList();
            ViewBag.Consted = consted;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult register()
        {
            return View();
        }

        public ActionResult shop()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult checkout()
        {
            return View();
        }

        public ActionResult single()
        {
            return View();
        }
    }
}