using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatRcontactWeb")]
	public partial class WeChatRcontactWebEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WeChatRcontactWebId;
             set => this.WeChatRcontactWebId = value;
         }	

		 [Key]
		 public string WeChatRcontactWebId {get;set;}

		 public string username {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public string CreateDate {get;set;}

		 public string UserId {get;set;}

		 public string Handle {get;set;}

		 public string UpdateTrueName {get;set;}

		 public string EmployeeId {get;set;}

		 public string WxUin {get;set;}

		 public string Assigned {get;set;}

	}
}
