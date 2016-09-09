using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemM.Data.SqlMapper;
namespace ItemM.Data.ObjectRelationManage
{
    /// <summary>
    /// 数据库基础配置链接类
    /// 作者：sul
    /// 时间：2016年8月27日17:45:30
    /// </summary>
    public class Database
    {
        /// 得到web.config里配置项的数据库连接字符串。  
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ToString();
        /// 得到工厂提供器类型  
        private static readonly string ProviderFactoryString = ConfigurationManager.AppSettings["DBProvider"].ToString();
        private static DbProviderFactory df = null;
        /// <summary>  
        /// 创建工厂提供器并且  
        /// </summary>  
        public static IDbConnection DbService()
        {
            if (df == null)
                df = DbProviderFactories.GetFactory(ProviderFactoryString);
            var connection = df.CreateConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();
            return connection;
        }
    }
}
