using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatExceptionRecord")]
	public partial class WechatExceptionRecordEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatExceptionRecordID;
             set => this.WechatExceptionRecordID = value;
         }	

		 [Key]
		 public string WechatExceptionRecordID {get;set;}

		 public string WechatUin {get;set;}

		 public string WechatState {get;set;}

		 public string ExceptionType {get;set;}

		 public string ExceptionTime {get;set;}

		 public string UnExceptionTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
