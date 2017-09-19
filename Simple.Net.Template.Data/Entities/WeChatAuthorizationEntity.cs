using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatAuthorization")]
	public partial class WeChatAuthorizationEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatId;
             set => this.WechatId = value;
         }	

		 [Key]
		 public string WechatId {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string ContactInfo {get;set;}

		 public string WechatUin {get;set;}

		 public string CompanyId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatNickName {get;set;}

		 public string EmployeeId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string WechatRemark {get;set;}

		 public string WechatStatue {get;set;}

		 public string WechatUpdateTime {get;set;}

		 public string ApplicationId {get;set;}

		 public string ApplicationName {get;set;}

		 public string DeviceId {get;set;}

	}
}
