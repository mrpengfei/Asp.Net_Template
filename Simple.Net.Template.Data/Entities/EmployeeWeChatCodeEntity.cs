using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeWeChatCode")]
	public partial class EmployeeWeChatCodeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeWechatCodeId;
             set => this.EmployeeWechatCodeId = value;
         }	

		 [Key]
		 public int EmployeeWechatCodeId {get;set;}

		 public int EmployeeId {get;set;}

		 public string WechatCode {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
