﻿using System.Web;
using System.Web.Optimization;

namespace ItemM.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Black/css").Include(
          "~/Content/Black/bootstrap.css",
          "~/Content/Black/sb-admin.css",
          "~/Content/Black/plugins/morris.css",
          "~/Content/Black/font-awesome/css/font-awesome.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/Black/jquery").Include(
            "~/KScripts/jquery.js"));
            bundles.Add(new ScriptBundle("~/bundles/Black/jqueryq").Include(
            "~/KScripts/bootstrap.min.js",
            "~/KScripts/plugins/morris/raphael.min.js",
            "~/KScripts/plugins/morris/morris.min.js",
            "~/KScripts/plugins/morris/morris-data.js"));
            #region oldjs
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion oldjs
        }
    }
}
