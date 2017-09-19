using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatContactBakWeb")]
	public partial class WechatContactBakWebEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatContactBakWebId;
             set => this.WechatContactBakWebId = value;
         }	

		 [Key]
		 public string WechatContactBakWebId {get;set;}

		 public string username {get;set;}

		 public string wxusername {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public string UserId {get;set;}

		 public string OldUserId {get;set;}

		 public string Handle {get;set;}

		 public string EmployeeId {get;set;}

		 public string WxUin {get;set;}

		 public string CreateDate {get;set;}

	}
}
