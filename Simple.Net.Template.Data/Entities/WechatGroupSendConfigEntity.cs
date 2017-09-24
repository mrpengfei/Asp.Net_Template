using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupSendConfig")]
	public partial class WechatGroupSendConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatGroupSendId;
             set => this.WechatGroupSendId = value;
         }	

		 [Key]
		 public int WechatGroupSendId {get;set;}

		 public int SendCount {get;set;}

		 public int IntervalMinutes {get;set;}

		 public int IntervalSeconds {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
