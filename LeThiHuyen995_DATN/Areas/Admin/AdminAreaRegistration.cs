using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;

namespace LeThiHuyen995_DATN.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "Admin_home",
                "admin",
                new {controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LeThiHuyen995_DATN.Areas.Admin.Controllers" }
            );
            
        }
    }
}