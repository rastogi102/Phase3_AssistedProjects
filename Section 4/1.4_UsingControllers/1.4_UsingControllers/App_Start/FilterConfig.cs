﻿using System.Web;
using System.Web.Mvc;

namespace _1._4_UsingControllers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
