using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatAuthorizationUpdateLog")]
	public partial class WeChatAuthorizationUpdateLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WeChatAuthorizationUpdateLogId;
             set => this.WeChatAuthorizationUpdateLogId = value;
         }	

		 [Key]
		 public int WeChatAuthorizationUpdateLogId {get;set;}

		 public int WechatId {get;set;}

		 public string WechatUin {get;set;}

		 public DateTime WechatUpdateTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
