using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatAuthorizationUpdateLog")]
	public partial class WeChatAuthorizationUpdateLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WeChatAuthorizationUpdateLogId;
             set => this.WeChatAuthorizationUpdateLogId = value;
         }	

		 [Key]
		 public string WeChatAuthorizationUpdateLogId {get;set;}

		 public string WechatId {get;set;}

		 public string WechatUin {get;set;}

		 public string WechatUpdateTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
