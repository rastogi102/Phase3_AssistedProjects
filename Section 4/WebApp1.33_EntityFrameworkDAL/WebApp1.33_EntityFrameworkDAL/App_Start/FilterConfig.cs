﻿using System.Web;
using System.Web.Mvc;

namespace WebApp1._33_EntityFrameworkDAL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
