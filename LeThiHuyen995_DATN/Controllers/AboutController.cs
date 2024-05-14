using LeThiHuyen995_DATN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Controllers
{
    public class AboutController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: About
        public ActionResult Index()
        {
            var item = db.Advs.FirstOrDefault(x => x.Id == 3);
            return View(item);
        }
    }
}