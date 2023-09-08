using System.Web;
using System.Web.Mvc;

namespace WebAPI1._3_CreatingWebServices
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
