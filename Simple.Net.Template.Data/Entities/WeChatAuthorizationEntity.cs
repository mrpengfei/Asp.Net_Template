using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatAuthorization")]
	public partial class WeChatAuthorizationEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatId;
             set => this.WechatId = value;
         }	

		 [Key]
		 public int WechatId {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string ContactInfo {get;set;}

		 public string WechatUin {get;set;}

		 public int CompanyId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatNickName {get;set;}

		 public int EmployeeId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public string WechatRemark {get;set;}

		 public string WechatStatue {get;set;}

		 public DateTime WechatUpdateTime {get;set;}

		 public string ApplicationId {get;set;}

		 public string ApplicationName {get;set;}

	}
}
