﻿using LeThiHuyen995_DATN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CheckOut()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                ViewBag.CheckCart = cart;
            }
            return View();
        }
        public ActionResult Partial_Item_Cart()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                return PartialView(cart.Items);
            }
            return PartialView();
        }
        public ActionResult Partial_Item_CheckOut()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                return PartialView(cart.Items);
            }
            return PartialView();
        }

        public ActionResult ShowCount()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                return Json(new { count = cart.Items.Count }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { scount = 0 }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            var code = new { success = false, msg = "", code = -1, count = 0 };
            var db = new ApplicationDbContext();
            var checkProduct = db.Products.FirstOrDefault(p => p.Id == id);
            if (checkProduct != null)
            {
                ShoppingCart cart = (ShoppingCart)Session["Cart"];
                if (cart == null)
                {
                    cart = new ShoppingCart();
                }
                ShoppingCartItem item = new ShoppingCartItem
                {
                    ProductId = checkProduct.Id,
                    ProductName = checkProduct.Title,
                    Alias = checkProduct.Alias,
                    Quantity = quantity
                };
                if (checkProduct.ProductImage.FirstOrDefault(x => x.IsDefault) != null)
                {
                    item.ProductImg = checkProduct.ProductImage.FirstOrDefault(x => x.IsDefault).Image;
                }
                item.Price = checkProduct.Price;
                if (checkProduct.PriceSale > 0)
                {
                    item.Price = (decimal)checkProduct.PriceSale;
                }
                item.TotalPrice = item.Price * item.Quantity;
                cart.AddToCart(item, quantity);
                Session["Cart"] = cart;
                code = new { success = true, msg = "Thêm sản phẩm vào giỏ hàng thành công", code = 1, count = cart.Items.Count };
            }
            return Json(code);
        }

        [HttpPost]
        public ActionResult Update(int id, int quantity)
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                cart.UpdateQuantity(id, quantity);
                return Json(new { success = true });
            }
            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var code = new { success = false, msg = "", code = -1, count = 0 };
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if(cart != null)
            {
                var checkProduct = cart.Items.FirstOrDefault(x=>x.ProductId == id);
                if(checkProduct != null)
                {
                    cart.Remove(id);
                    code = new { success = true, msg = "", code = 1, count = cart.Items.Count };

                }
            }
            return Json(code);
        }

        [HttpPost]
        public ActionResult DeleteAll()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                cart.ClearCart();
                return Json(new { success = true });
            }
            return Json(new { success = true });
        }
    }
}
