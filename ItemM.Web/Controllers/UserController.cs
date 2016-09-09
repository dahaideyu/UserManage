using DataEntity;
using ItemM.Data.ObjectRelationManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ItemM.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(int pageSize=20,int pageIndex=1)
        {
            List<Sys_userEntity> lstEntity = new List<Sys_userEntity>();
            StringBuilder afterFromSql = new StringBuilder(
                 string.Format("{0}  ", Sys_userEntity.Sql.PartAfterFromSql));
   

            DataPage dp = new DataPage();
            dp.PageIndex = pageIndex;
            dp.PageSize = pageSize;
            dp.OrderField = " SysUserID asc";
            lstEntity = DalHelper.Instance.GetDpList<Sys_userEntity>(Sys_userEntity.Sql.PartSqlFields, afterFromSql.ToString(), null, dp);
            return View(lstEntity);
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Editor(int id)
        {
            Sys_userEntity sys_userEntity = new Sys_userEntity();
            if (id>0)
            {
                sys_userEntity = DalHelper.Instance.Get<Sys_userEntity>(id);
            }
            return View(sys_userEntity);
        }
        [HttpPost]
        public ActionResult Editor(Sys_userEntity newsEntity)
        {
       
           newsEntity.CreateDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                bool editFlag = false;
                newsEntity.SetDefaultValue();
           

            
                if (newsEntity.SysUserID> 0)
                {
                    editFlag = DalHelper.Instance.Edit<Sys_userEntity>(newsEntity);
                }
                else
                {
                    editFlag = DalHelper.Instance.Insert<Sys_userEntity>(newsEntity) > 0;
                }
                //MessageShow();
            }
            return View(newsEntity);
        }
        public ActionResult Add(Sys_userEntity newsEntity)
        {
            return View();
        }
        public ActionResult Del(long id)
        {
            bool result = false;
            string message = "删除失败！";
            if (id > 0)
            {
                Sys_userEntity sys_userEntity = new Sys_userEntity();
                sys_userEntity.SysUserID = id;
                result = DalHelper.Instance.Delete<Sys_userEntity>(sys_userEntity);
                message = "删除成功！";
            }
            return Json(new { result = result, message = message }, JsonRequestBehavior.AllowGet);
        }
    }
}