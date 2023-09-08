using System.Web;
using System.Web.Mvc;

namespace _1._4_Various_ActionResults
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
