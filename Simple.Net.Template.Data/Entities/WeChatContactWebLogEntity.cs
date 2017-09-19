using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatContactWebLog")]
	public partial class WeChatContactWebLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WeChatContactWebLogId;
             set => this.WeChatContactWebLogId = value;
         }	

		 [Key]
		 public string WeChatContactWebLogId {get;set;}

		 public string UserId {get;set;}

		 public string ContactInfo {get;set;}

		 public string WxUin {get;set;}

		 public string EmployeeId {get;set;}

		 public string Assigned {get;set;}

		 public string Handle {get;set;}

		 public string TrueName {get;set;}

		 public string UpdateTrueName {get;set;}

		 public string AddType {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
