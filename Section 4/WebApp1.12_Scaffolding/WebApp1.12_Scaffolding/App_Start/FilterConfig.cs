﻿using System.Web;
using System.Web.Mvc;

namespace WebApp1._12_Scaffolding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
