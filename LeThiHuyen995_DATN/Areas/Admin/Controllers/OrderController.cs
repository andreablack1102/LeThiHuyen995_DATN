using LeThiHuyen995_DATN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using PagedList;
using System.Web.Services.Description;

namespace LeThiHuyen995_DATN.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Manager")]
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var items = db.Orders.OrderByDescending(x => x.CreatedDate).ToList();
            if (page == null)
            {
                page = 1;
            }
            var pageSize = 10;
            var pageNumber = page ?? 1;
            ViewBag.Page = pageNumber;
            ViewBag.PageSize = pageSize;
            return View(items.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult View(int id)
        {
            var item = db.Orders.Find(id);
            return View(item);
        }

        public ActionResult Partial_Product(int id)
        {
            var items = db.OrderDetails.Where(x => x.OrderId == id).ToList();
            return PartialView(items);
        }

        [HttpPost]
        public ActionResult UpdateTT(int id, int trangThai)
        {
            var item = db.Orders.Find(id);
            if(item != null)
            {
                db.Orders.Attach(item);
                item.Status = trangThai;
                db.Entry(item).Property(x=>x.TypePayment).IsModified = true;
                db.SaveChanges();
                return Json(new { message = "Success", success = true });
            }
            return Json(new { message = "Unsuccess", success = false });
        }
    }
}