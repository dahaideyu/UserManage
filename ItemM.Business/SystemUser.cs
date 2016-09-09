using DataEntity;
using ItemM.Data.ObjectRelationManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemM.Business
{
  public  class SystemUser
    {
        public Sys_userEntity GetLoginMember(string userName, string pwd)
        {
            Sys_userEntity member = new Sys_userEntity();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pwd))
            {
                return member;
            }

            member = DalHelper.Instance.GetSqlDefaultEntity<Sys_userEntity>(
                string.Format("{0} and @{1}={1} and @{2}={2}",
                Sys_userEntity.Sql.SqlDetail,
                Sys_userEntity.Fields.UserName,
                Sys_userEntity.Fields.Password),
                new
                {
                    UserName = userName,
                    Password = pwd,
                });

            return member ?? new Sys_userEntity();
        }
    }
}
