using LeThiHuyen995_DATN.Models;
using LeThiHuyen995_DATN.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/News
        public ActionResult Index()
        {
            var items = db.News.OrderByDescending(x=>x.Id).ToList();
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(News model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.CategoryId = 3;
                model.Alias = LeThiHuyen995_DATN.Models.Common.Filter.FilterChar(model.Title);
                db.News.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        //public ActionResult Edit(int id)
        //{
        //    var item = db.Categories.Find(id);
        //    return View(item);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Category model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Categories.Attach(model);
        //        model.ModifiedDate = DateTime.Now;
        //        model.Alias = LeThiHuyen995_DATN.Models.Common.Filter.FilterChar(model.Title);
        //        db.Entry(model).Property(x => x.Title).IsModified = true;
        //        db.Entry(model).Property(x => x.Description).IsModified = true;
        //        db.Entry(model).Property(x => x.Alias).IsModified = true;
        //        db.Entry(model).Property(x => x.SeoDescription).IsModified = true;
        //        db.Entry(model).Property(x => x.SeoKeywords).IsModified = true;
        //        db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
        //        db.Entry(model).Property(x => x.Position).IsModified = true;
        //        db.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
        //        db.Entry(model).Property(x => x.ModifiedBy).IsModified = true;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    var item = db.Categories.Find(id);
        //    if (item != null)
        //    {
        //        //var DeleteItem = db.Categories.Attach(item);
        //        db.Categories.Remove(item);
        //        db.SaveChanges();
        //        return Json(new { success = true });
        //    }
        //    return Json(new { success = false });
        //}
    }
}