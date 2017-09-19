using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupSendConfig ")]
	public partial class WechatGroupSendConfig Entity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatGroupSendId;
             set => this.WechatGroupSendId = value;
         }	

		 [Key]
		 public string WechatGroupSendId {get;set;}

		 public string SendCount {get;set;}

		 public string IntervalMinutes {get;set;}

		 public string IntervalSeconds {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
