using LeThiHuyen995_DATN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuTop()
        {
            var items = db.Categories.OrderBy(x=>x.Position).ToList();
            return PartialView("_MenuTop", items);
        }

        //SUA THANH 3 SAN PHAM CO LUOT TRUY CAP NHIEU NHAT
        //public ActionResult MenuProductCategory()
        //{
        //    var items = db.ProductCategories.Take(3).ToList();
        //    return PartialView("_MenuProductCategory", items);
        //}
        public ActionResult MenuLeft(int? id)
        {
            if (id != null)
            {
                ViewBag.Id = id;
            }
            var items = db.ProductCategories.ToList();
            return PartialView("_MenuLeft", items);
        }

        public ActionResult MenuArrivals()
        {
            var items = db.ProductCategories.ToList();
            return PartialView("_MenuArrivals", items);
        }
    }
}