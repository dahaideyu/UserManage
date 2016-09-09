﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2016-09-04 20:52:13 AuthBy:cmm
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataEntity
{	
	[Table("Sys_user")] 
	public partial class Sys_userEntity
    {
		#region 属性
				
		/// <summary>
		/// 
		/// </summary>	
		[Key] 
		 
		 
		[Display(Name = "")]
		 
		public string UserCode { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(10)] 
		[Display(Name = "")]
		 
		public string UserSeq { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(200)] 
		[Display(Name = "")]
		 
		public string UserName { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(2048)] 
		[Display(Name = "")]
		 
		public string Description { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(40)] 
		[Display(Name = "")]
		 
		public string Password { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(1000)] 
		[Display(Name = "")]
		 
		public string RoleName { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(1000)] 
		[Display(Name = "")]
		 
		public string OrganizeName { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(4000)] 
		[Display(Name = "")]
		 
		public string ConfigJSON { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		 
		[Display(Name = "")]
		 
		public bool IsEnable { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		 
		[Display(Name = "")]
		 
		public int LoginCount { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		 
		[Display(Name = "")]
		[DataType(DataType.DateTime)] 
		public DateTime LastLoginDate { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(20)] 
		[Display(Name = "")]
		 
		public string CreatePerson { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		 
		[Display(Name = "")]
		[DataType(DataType.DateTime)] 
		public DateTime CreateDate { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		[StringLength(20)] 
		[Display(Name = "")]
		 
		public string UpdatePerson { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		 
		 
		[Display(Name = "")]
		[DataType(DataType.DateTime)] 
		public DateTime UpdateDate { get; set; }
				
		/// <summary>
		/// 
		/// </summary>	
		 
		[Required] 
		 
		[Display(Name = "")]
		 
		public long SysUserID { get; set; }
		 
      #endregion

	   	#region 设置默认值
		///<summary>
		///set default value
		///</summary>
		public void SetDefaultValue()
		{
						if (this.UserCode == null) this.UserCode = "";
			if (this.UserSeq == null) this.UserSeq = "";
			if (this.UserName == null) this.UserName = "";
			if (this.Description == null) this.Description = "";
			if (this.Password == null) this.Password = "";
			if (this.RoleName == null) this.RoleName = "";
			if (this.OrganizeName == null) this.OrganizeName = "";
			if (this.ConfigJSON == null) this.ConfigJSON = "";
			if (this.LastLoginDate.Year<1900) this.LastLoginDate =  new DateTime(1900,01,01);
			if (this.CreatePerson == null) this.CreatePerson = "";
			if (this.CreateDate.Year<1900) this.CreateDate =  new DateTime(1900,01,01);
			if (this.UpdatePerson == null) this.UpdatePerson = "";
			if (this.UpdateDate.Year<1900) this.UpdateDate =  new DateTime(1900,01,01);

		}
		#endregion

		#region 字段
		public static class Fields
		{ 
			public const string DataBaseName= "ItemManage";

			public const string TableName = "dbo.Sys_user";

	   		public const string UserCode = "UserCode";
	   
	   		public const string UserSeq = "UserSeq";
	   
	   		public const string UserName = "UserName";
	   
	   		public const string Description = "Description";
	   
	   		public const string Password = "Password";
	   
	   		public const string RoleName = "RoleName";
	   
	   		public const string OrganizeName = "OrganizeName";
	   
	   		public const string ConfigJSON = "ConfigJSON";
	   
	   		public const string IsEnable = "IsEnable";
	   
	   		public const string LoginCount = "LoginCount";
	   
	   		public const string LastLoginDate = "LastLoginDate";
	   
	   		public const string CreatePerson = "CreatePerson";
	   
	   		public const string CreateDate = "CreateDate";
	   
	   		public const string UpdatePerson = "UpdatePerson";
	   
	   		public const string UpdateDate = "UpdateDate";
	   
	   		public const string SysUserID = "SysUserID";
	   
	   	  }
		#endregion

		#region	基本SQL
        public static class Sql 
        {
		   
		    //所有字段组成的字符串,逗号分隔
		    public static string PartSqlFields=" UserCode,UserSeq,UserName,Description,Password,RoleName,OrganizeName,ConfigJSON,IsEnable,LoginCount,LastLoginDate,CreatePerson,CreateDate,UpdatePerson,UpdateDate,SysUserID"; 

			//From后面部分的Sql语句
		    public static string PartAfterFromSql=" ItemManage.dbo.Sys_user  WITH(NOLOCK) WHERE 1=1 "; 
			
			//查询sql
			public static string SqlDetail="SELECT UserCode,UserSeq,UserName,Description,Password,RoleName,OrganizeName,ConfigJSON,IsEnable,LoginCount,LastLoginDate,CreatePerson,CreateDate,UpdatePerson,UpdateDate,SysUserID FROM ItemManage.dbo.Sys_user  WITH(NOLOCK) WHERE 1=1  ";
        }
		#endregion
    }
}

