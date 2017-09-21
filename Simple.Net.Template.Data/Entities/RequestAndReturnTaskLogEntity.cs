using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RequestAndReturnTaskLog")]
	public partial class RequestAndReturnTaskLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.RequestAndReturnTaskLogId;
             set => this.RequestAndReturnTaskLogId = value;
         }	

		 [Key]
		 public int RequestAndReturnTaskLogId {get;set;}

		 public string WechatUin {get;set;}

		 public int RType {get;set;}

		 public string ReturnParameter {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
