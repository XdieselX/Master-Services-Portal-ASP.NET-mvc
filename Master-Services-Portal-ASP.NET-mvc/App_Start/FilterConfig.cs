using System.Web;
using System.Web.Mvc;

namespace Master_Services_Portal_ASP.NET_mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
