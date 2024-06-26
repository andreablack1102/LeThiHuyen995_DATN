﻿using LeThiHuyen995_DATN.Models;
using LeThiHuyen995_DATN.Models.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace LeThiHuyen995_DATN.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        //public ActionResult Index(int ?id)
        //{
            
        //    var items = db.Products.ToList();
        //    if (id != null)
        //    {
        //        items = items.Where(x=>x.ProductCategoryId == id).ToList();
        //    }
        //    return View(items);
        //}
        public ActionResult Index(string searchText, int? page)
        {
            IEnumerable<Product> items = db.Products.OrderByDescending(x => x.CreatedDate);
            var pageSize = 20;
            if (page == null)
            {
                page = 1;
            }
            if (!string.IsNullOrEmpty(searchText))
            {
                items = items.Where(x => x.Alias.Contains(LeThiHuyen995_DATN.Models.Common.Filter.FilterChar(searchText)) || x.Title.Contains(searchText));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            
            return View(items);
        }
        public ActionResult Detail(string alias, int id)
        {
            var item = db.Products.Find(id);
            if(item != null)
            {
                db.Products.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                db.Entry(item).Property(x=>x.ViewCount).IsModified = true;
                db.SaveChanges();
            }
            var countReview = db.Reviews.Where(x=>x.ProductId== id).Count();
            ViewBag.CountReview = countReview;
            return View(item);
        }
        public ActionResult FilterByProductCategoryId(string alias, int id, int? page)
        {

            IEnumerable<Product> items = db.Products;
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryId == id);
            }
            var pageSize = 20;
            if (page == null)
            {
                page = 1;
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            var cate = db.ProductCategories.Find(id);
            if(cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateId = id;
            return View(items);
        }

        public ActionResult Partial_ItemByCateId()
        {
            var items = db.Products.OrderByDescending(x => x.CreatedDate).Where(x => x.IsHome && x.IsActive).Take(15).ToList();
            return PartialView(items);
        }

        public ActionResult Partial_ProductSales()
        {
            var items = db.Products.Where(x => x.IsSale && x.IsActive).Take(6).ToList();
            return PartialView(items);
        }

        public ActionResult Partial_ProductSimilar(int id)
        {
            var items = db.Products.Where(x => x.ProductCategoryId == id).Take(5).ToList();
            return PartialView(items);
        }
    }
}