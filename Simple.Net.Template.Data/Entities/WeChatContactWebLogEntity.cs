using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatContactWebLog")]
	public partial class WeChatContactWebLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WeChatContactWebLogId;
             set => this.WeChatContactWebLogId = value;
         }	

		 [Key]
		 public int WeChatContactWebLogId {get;set;}

		 public string UserId {get;set;}

		 public string ContactInfo {get;set;}

		 public string WxUin {get;set;}

		 public int EmployeeId {get;set;}

		 public bool Assigned {get;set;}

		 public bool Handle {get;set;}

		 public string TrueName {get;set;}

		 public bool UpdateTrueName {get;set;}

		 public int AddType {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
