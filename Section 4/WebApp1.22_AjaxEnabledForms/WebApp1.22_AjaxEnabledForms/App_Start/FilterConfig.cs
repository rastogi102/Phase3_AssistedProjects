﻿using System.Web;
using System.Web.Mvc;

namespace WebApp1._22_AjaxEnabledForms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
