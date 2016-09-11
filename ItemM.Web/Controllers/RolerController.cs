using DataEntity;
using ItemM.Data.ObjectRelationManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace ItemM.Web.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public class RolerController : Controller
    {
        // GET: Roler
        public ActionResult Index(int id)
        {
            int pageIndex = id;
            int pageSize = 20;
            List<Sys_roleEntity> lstEntity = new List<Sys_roleEntity>();
            StringBuilder afterFromSql = new StringBuilder(string.Format("{0}  ", Sys_roleEntity.Sql.PartAfterFromSql));
            DataPage dp = new DataPage();
            dp.PageIndex = pageIndex;
            dp.PageSize = pageSize;
            dp.OrderField = " SysUserID asc";
            lstEntity = DalHelper.Instance.GetDpList<Sys_roleEntity>(Sys_roleEntity.Sql.PartSqlFields, afterFromSql.ToString(), null, dp);
            PagedList<Sys_roleEntity> userPageList = lstEntity.ToPagedList(pageIndex, pageSize);
            userPageList.TotalItemCount = (int)dp.RowCount;
            userPageList.CurrentPageIndex = pageIndex;
            return View(userPageList);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Sys_roleEntity roleEntity)
        {
            if (ModelState.IsValid)
            {
                roleEntity.CreateDate = DateTime.Now;
                roleEntity.UpdateDate = DateTime.Now;
                bool editFlag = false;
                roleEntity.SetDefaultValue();
                editFlag = DalHelper.Instance.Insert<Sys_roleEntity>(roleEntity) > 0;
            }
            return View(roleEntity);
        }
        [HttpGet]
        public ActionResult Editor(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editor(Sys_roleEntity roleEntity)
        {
            return View();
        }
        public ActionResult Del(int id)
        {
            return Json(new { message=""},JsonRequestBehavior.AllowGet);
        }
    }
}