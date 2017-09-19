using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatSearchAddFriendLog")]
	public partial class WechatSearchAddFriendLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatSearchAddFriendLogId;
             set => this.WechatSearchAddFriendLogId = value;
         }	

		 [Key]
		 public string WechatSearchAddFriendLogId {get;set;}

		 public string WechatUin {get;set;}

		 public string EmployeeId {get;set;}

		 public string WechatContactInfo {get;set;}

		 public string GreetContent {get;set;}

		 public string UserTrueName {get;set;}

		 public string UserId {get;set;}

		 public string AddStatus {get;set;}

		 public string AddTimes {get;set;}

		 public string AddDate {get;set;}

		 public string Remark {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
