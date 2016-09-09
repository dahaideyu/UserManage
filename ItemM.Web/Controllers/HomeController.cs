using DataEntity;
using ItemM.Business;
using ItemM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ItemM.Web.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            return View();
        }
    
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginEntity loginer)
        {
            ModelState.Clear();

            if (string.IsNullOrEmpty(loginer.UserName) || string.IsNullOrEmpty(loginer.PassWord))
            {
                ModelState.AddModelError("Account", "请完善账户名和密码。");
                return View();
            }
            SystemUser sysUser = new SystemUser();
            Sys_userEntity sysUserEntity= sysUser.GetLoginMember(loginer.UserName, loginer.PassWord);
            
            if (sysUserEntity != null)
            {
                string userData = loginer.UserName + "#" + loginer.PassWord;
                //数据放入ticket
                var ticket = new FormsAuthenticationTicket(1, loginer.UserName, DateTime.Now, DateTime.Now.AddMinutes(60), false, userData);
                //数据加密
                string enyTicket = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, enyTicket)
                {
                    HttpOnly = true,
                    Secure = FormsAuthentication.RequireSSL,
                    Domain = FormsAuthentication.CookieDomain,
                    Path = FormsAuthentication.FormsCookiePath
                }; 
                cookie.Expires = DateTime.Now.AddMinutes(4000);
                var context = System.Web.HttpContext.Current;
                if (context == null)
                {
                    throw new InvalidOperationException();
                }
                context.Response.Cookies.Remove(cookie.Name);
                context.Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Account", "账户名和密码错误！");
                return View();
            }

       
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login");
        }
    }
}