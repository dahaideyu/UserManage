using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ItemM.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            #region autofac
            ContainerBuilder builder = new ContainerBuilder();
            //注册了当前程序集内所有的Controller类
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //注册了当前程序集内的所有类
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //forexample builder.RegisterType<DbLog>().As<ILog>();
            //注册所有实现IEnumerable接口的类中带array的用ArrayList实现
            //builder.RegisterType<ArrayList>().Named<IEnumerable>("array");
            #endregion autofac
        }
    }
}
