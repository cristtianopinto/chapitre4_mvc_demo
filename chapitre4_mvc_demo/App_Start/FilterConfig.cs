﻿using System.Web;
using System.Web.Mvc;

namespace chapitre4_mvc_demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
