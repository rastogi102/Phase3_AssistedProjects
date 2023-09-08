using System.Web;
using System.Web.Mvc;

namespace WebApp1._14_Using_Custom_Filters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
