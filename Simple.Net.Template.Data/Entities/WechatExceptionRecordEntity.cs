using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatExceptionRecord")]
	public partial class WechatExceptionRecordEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatExceptionRecordID;
             set => this.WechatExceptionRecordID = value;
         }	

		 [Key]
		 public int WechatExceptionRecordID {get;set;}

		 public string WechatUin {get;set;}

		 public bool WechatState {get;set;}

		 public int ExceptionType {get;set;}

		 public DateTime ExceptionTime {get;set;}

		 public DateTime UnExceptionTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
