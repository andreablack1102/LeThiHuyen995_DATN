using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LeThiHuyen995_DATN
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Contact",
                url: "lien-he",
                defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "ShoppingCart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "ChiTietDon",
                url: "chi-tiet-don/{id}",
                defaults: new { controller = "Review", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "CategoryProduct",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products", action = "FilterByProductCategoryId", id = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "Intro",
                url: "gioi-thieu",
                defaults: new { controller = "Advertise", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );

            routes.MapRoute(
                name: "DetailProducts",
                url: "chitiet/{alias}-p{id}",
                defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "Products",
                url: "san-pham",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "NewsList",
                url: "bai-viet",
                defaults: new { controller = "News", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            
            routes.MapRoute(
                name: "DetailNews",
                url: "{alias}-n{id}",
                defaults: new { controller = "News", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Controllers" }
            );
        }
    }
}
