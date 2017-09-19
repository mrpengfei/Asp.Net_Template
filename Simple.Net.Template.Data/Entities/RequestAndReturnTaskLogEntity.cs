using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RequestAndReturnTaskLog")]
	public partial class RequestAndReturnTaskLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.RequestAndReturnTaskLogId;
             set => this.RequestAndReturnTaskLogId = value;
         }	

		 [Key]
		 public string RequestAndReturnTaskLogId {get;set;}

		 public string WechatUin {get;set;}

		 public string RType {get;set;}

		 public string ReturnParameter {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
