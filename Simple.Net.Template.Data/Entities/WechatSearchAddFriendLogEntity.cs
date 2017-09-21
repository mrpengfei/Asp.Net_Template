using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatSearchAddFriendLog")]
	public partial class WechatSearchAddFriendLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatSearchAddFriendLogId;
             set => this.WechatSearchAddFriendLogId = value;
         }	

		 [Key]
		 public int WechatSearchAddFriendLogId {get;set;}

		 public string WechatUin {get;set;}

		 public int EmployeeId {get;set;}

		 public string WechatContactInfo {get;set;}

		 public string GreetContent {get;set;}

		 public string UserTrueName {get;set;}

		 public string UserId {get;set;}

		 public int AddStatus {get;set;}

		 public int AddTimes {get;set;}

		 public DateTime AddDate {get;set;}

		 public string Remark {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
