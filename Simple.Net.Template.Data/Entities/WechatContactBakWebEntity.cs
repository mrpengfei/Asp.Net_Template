using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatContactBakWeb")]
	public partial class WechatContactBakWebEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatContactBakWebId;
             set => this.WechatContactBakWebId = value;
         }	

		 [Key]
		 public int WechatContactBakWebId {get;set;}

		 public string username {get;set;}

		 public string wxusername {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public string UserId {get;set;}

		 public string OldUserId {get;set;}

		 public bool Handle {get;set;}

		 public int EmployeeId {get;set;}

		 public string WxUin {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
