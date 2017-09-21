using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatExceptionRecordLog")]
	public partial class WechatExceptionRecordLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatExceptionRecordLogId;
             set => this.WechatExceptionRecordLogId = value;
         }	

		 [Key]
		 public int WechatExceptionRecordLogId {get;set;}

		 public string WechatUin {get;set;}

		 public string WechatState {get;set;}

		 public int ExceptionType {get;set;}

		 public DateTime ExceptionTime {get;set;}

		 public DateTime UnExceptionTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
