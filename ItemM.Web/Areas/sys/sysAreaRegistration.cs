﻿using System.Web.Mvc;

namespace ItemM.Web.Areas.sys
{
    public class sysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "sys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "sys_default",
                "sys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}