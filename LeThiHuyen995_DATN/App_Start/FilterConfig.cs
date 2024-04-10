using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
