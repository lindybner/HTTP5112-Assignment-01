﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5112_Assignment_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
