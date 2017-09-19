using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeWeChatCode")]
	public partial class EmployeeWeChatCodeEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeWechatCodeId;
             set => this.EmployeeWechatCodeId = value;
         }	

		 [Key]
		 public string EmployeeWechatCodeId {get;set;}

		 public string EmployeeId {get;set;}

		 public string WechatCode {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
