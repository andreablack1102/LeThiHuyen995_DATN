using LeThiHuyen995_DATN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Controllers
{
    public class AdvertiseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Advertise
        public ActionResult Index()
        {
            var item = db.Advs.Find(2);
            return View(item);
        }
        public ActionResult Partial_Adv()
        {
            var item = db.Advs.Take(1).ToList();
            return PartialView(item);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    base.Dispose(disposing);
        //}
    }
}