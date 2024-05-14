using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Manager,Employee")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}