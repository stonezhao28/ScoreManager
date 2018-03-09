
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `SqlServerConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=120.27.27.115;Initial Catalog=ScoreManage;User ID=sa;password=**zapped**;`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using PetaPoco;

namespace MT.Models
{



    
	[TableName("Role")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class RoleModel : Record<RoleModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("Remark")] public string Remark { get; set; }







		[Column("SortNo")] public int? SortNo { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("ModifyMan")] public int? ModifyMan { get; set; }







		[Column("ModifyTime")] public DateTime? ModifyTime { get; set; }







		[Column("ProductId")] public int? ProductId { get; set; }




	}

    
	[TableName("Symbol")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class SymbolModel : Record<SymbolModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("SymbolName")] public string SymbolName { get; set; }




	}

    
	[TableName("SystemLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class SystemLogModel : Record<SystemLogModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("UserID")] public int? UserID { get; set; }







		[Column("Type")] public int? Type { get; set; }







		[Column("LogInfo")] public string LogInfo { get; set; }







		[Column("InsTime")] public DateTime? InsTime { get; set; }







		[Column("IP")] public string IP { get; set; }







		[Column("Parameters")] public string Parameters { get; set; }




	}

    
	[TableName("SystemParam")]


	[PrimaryKey("ParamID")]



	[ExplicitColumns]
    public partial class SystemParamModel : Record<SystemParamModel>  
    {




		[Column("ParamID")] public string ParamID { get; set; }







		[Column("ParamName")] public string ParamName { get; set; }







		[Column("ParamValue")] public string ParamValue { get; set; }







		[Column("Description")] public string Description { get; set; }







		[Column("Remarks")] public string Remarks { get; set; }







		[Column("OrderNo")] public int? OrderNo { get; set; }




	}

    
	[TableName("Area")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class AreaModel : Record<AreaModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Code")] public string Code { get; set; }







		[Column("ParentCode")] public string ParentCode { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("FullName")] public string FullName { get; set; }







		[Column("Del_Flag")] public int? Del_Flag { get; set; }







		[Column("Create_Time")] public DateTime? Create_Time { get; set; }







		[Column("Create_Man")] public string Create_Man { get; set; }




	}

    
	[TableName("User")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class UserModel : Record<UserModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("Password")] public string Password { get; set; }







		[Column("NickName")] public string NickName { get; set; }







		[Column("Sex")] public string Sex { get; set; }







		[Column("CompanyId")] public int? CompanyId { get; set; }







		[Column("CompanyCode")] public string CompanyCode { get; set; }







		[Column("CompanyName")] public string CompanyName { get; set; }







		[Column("UserType")] public string UserType { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("ModifyMan")] public int? ModifyMan { get; set; }







		[Column("ModifyTime")] public DateTime? ModifyTime { get; set; }







		[Column("LastLoginTime")] public DateTime? LastLoginTime { get; set; }




	}

    
	[TableName("Cache")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class CacheModel : Record<CacheModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("CacheKey")] public string CacheKey { get; set; }







		[Column("CacheValue")] public string CacheValue { get; set; }







		[Column("Remark")] public string Remark { get; set; }







		[Column("CacheTimes")] public int? CacheTimes { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("CacheType")] public string CacheType { get; set; }




	}

    
	[TableName("UserInfo")]


	[PrimaryKey("UserID")]



	[ExplicitColumns]
    public partial class UserInfoModel : Record<UserInfoModel>  
    {




		[Column("UserID")] public string UserID { get; set; }







		[Column("Phone")] public string Phone { get; set; }







		[Column("Email")] public string Email { get; set; }







		[Column("Password")] public string Password { get; set; }







		[Column("UserType")] public int? UserType { get; set; }







		[Column("Sex")] public int? Sex { get; set; }







		[Column("Country")] public string Country { get; set; }







		[Column("CountryCode")] public string CountryCode { get; set; }







		[Column("UserName")] public string UserName { get; set; }







		[Column("UserNameCn")] public string UserNameCn { get; set; }







		[Column("Birthday")] public DateTime? Birthday { get; set; }







		[Column("UserStatus")] public int? UserStatus { get; set; }







		[Column("Province")] public string Province { get; set; }







		[Column("City")] public string City { get; set; }







		[Column("District")] public string District { get; set; }







		[Column("Address")] public string Address { get; set; }







		[Column("Zip")] public int? Zip { get; set; }







		[Column("IDcard")] public string IDcard { get; set; }







		[Column("Lang")] public string Lang { get; set; }







		[Column("LastLoginTime")] public DateTime? LastLoginTime { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("IntroID")] public int? IntroID { get; set; }







		[Column("LoginName")] public string LoginName { get; set; }







		[Column("WhichDepart")] public int? WhichDepart { get; set; }







		[Column("PID")] public string PID { get; set; }







		[Column("UpdateTime")] public DateTime? UpdateTime { get; set; }




	}

    
	[TableName("UserLoginLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class UserLoginLogModel : Record<UserLoginLogModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("UserID")] public int? UserID { get; set; }







		[Column("LoginTime")] public DateTime? LoginTime { get; set; }







		[Column("LoginIp")] public string LoginIp { get; set; }







		[Column("DeviceID")] public string DeviceID { get; set; }







		[Column("DeviceOS")] public string DeviceOS { get; set; }







		[Column("AppVersion")] public string AppVersion { get; set; }




	}

    
	[TableName("UserProduct")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class UserProductModel : Record<UserProductModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("ProductId")] public int? ProductId { get; set; }







		[Column("UserId")] public int? UserId { get; set; }




	}

    
	[TableName("Config")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ConfigModel : Record<ConfigModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("ConfigKey")] public string ConfigKey { get; set; }







		[Column("ConfigData")] public string ConfigData { get; set; }







		[Column("ConfigType")] public string ConfigType { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}

    
	[TableName("Country")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class CountryModel : Record<CountryModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("NameCN")] public string NameCN { get; set; }







		[Column("Abbreviation")] public string Abbreviation { get; set; }







		[Column("AreaCode")] public string AreaCode { get; set; }




	}

    
	[TableName("UserRole")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class UserRoleModel : Record<UserRoleModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("UserID")] public int? UserID { get; set; }







		[Column("RoleID")] public int? RoleID { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}

    
	[TableName("Demo")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class DemoModel : Record<DemoModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("DemoRedioButton")] public int? DemoRedioButton { get; set; }







		[Column("DemoCheckBox")] public string DemoCheckBox { get; set; }







		[Column("DemoSelected")] public int? DemoSelected { get; set; }







		[Column("DemoTextArea")] public string DemoTextArea { get; set; }







		[Column("DemoText")] public string DemoText { get; set; }







		[Column("Phone")] public string Phone { get; set; }







		[Column("IDCard")] public string IDCard { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("Createtime")] public DateTime? Createtime { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }




	}

    
	[TableName("File")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class FileModel : Record<FileModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("PathName")] public string PathName { get; set; }







		[Column("ShowName")] public string ShowName { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}

    
	[TableName("GlobalSql")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class GlobalSqlModel : Record<GlobalSqlModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("SQLKey")] public string SQLKey { get; set; }







		[Column("SQLContent")] public string SQLContent { get; set; }







		[Column("SqlConnection")] public string SqlConnection { get; set; }







		[Column("Remark")] public string Remark { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}

    
	[TableName("Group")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class GroupModel : Record<GroupModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("Title")] public string Title { get; set; }







		[Column("Target")] public string Target { get; set; }







		[Column("Url")] public string Url { get; set; }







		[Column("IcoCss")] public string IcoCss { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("SortNo")] public int? SortNo { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("ProductId")] public int? ProductId { get; set; }




	}

    
	[TableName("Log")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class LogModel : Record<LogModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("UserID")] public int? UserID { get; set; }







		[Column("TableName")] public string TableName { get; set; }







		[Column("LogType")] public string LogType { get; set; }







		[Column("SQLInfo")] public string SQLInfo { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}

    
	[TableName("Node")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class NodeModel : Record<NodeModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("Title")] public string Title { get; set; }







		[Column("HeadTitle")] public string HeadTitle { get; set; }







		[Column("HeadKeywords")] public string HeadKeywords { get; set; }







		[Column("HeadDescription")] public string HeadDescription { get; set; }







		[Column("DisplayFlag")] public int? DisplayFlag { get; set; }







		[Column("Area")] public string Area { get; set; }







		[Column("Pid")] public string Pid { get; set; }







		[Column("NodeLevel")] public int? NodeLevel { get; set; }







		[Column("Link")] public string Link { get; set; }







		[Column("GroupID")] public int? GroupID { get; set; }







		[Column("Target")] public string Target { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("SortNo")] public int? SortNo { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }







		[Column("ModifyMan")] public int? ModifyMan { get; set; }







		[Column("ModifyTIme")] public DateTime? ModifyTIme { get; set; }







		[Column("ProductId")] public int? ProductId { get; set; }







		[Column("IcoCss")] public string IcoCss { get; set; }




	}

    
	[TableName("Product")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ProductModel : Record<ProductModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("Name")] public string Name { get; set; }







		[Column("SortNo")] public int? SortNo { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }




	}

    
	[TableName("Access")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class AccessModel : Record<AccessModel>  
    {




		[Column("ID")] public string ID { get; set; }







		[Column("RoleID")] public int? RoleID { get; set; }







		[Column("NodeID")] public int? NodeID { get; set; }







		[Column("DelFlag")] public int? DelFlag { get; set; }







		[Column("CreateMan")] public int? CreateMan { get; set; }







		[Column("CreateTime")] public DateTime? CreateTime { get; set; }




	}


}


