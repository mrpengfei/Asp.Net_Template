using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatTaskExtend")]
	public partial class WechatTaskExtendEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatTaskExtendId;
             set => this.WechatTaskExtendId = value;
         }	

		 [Key]
		 public string WechatTaskExtendId {get;set;}

		 public string MainTaskId {get;set;}

		 public string WxUin {get;set;}

		 public string ExtendCount {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatGroupConfigId {get;set;}

	}
}
