using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItemM.Web.Models
{
    /// <summary>
    /// 用户登录实体
    /// </summary>
    public class LoginEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [Required]
        public string PassWord { get; set; }
    }
}