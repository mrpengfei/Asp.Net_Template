using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatSearchAddFriendConfig")]
	public partial class WechatSearchAddFriendConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatSearchAddFriendConfigId;
             set => this.WechatSearchAddFriendConfigId = value;
         }	

		 [Key]
		 public int WechatSearchAddFriendConfigId {get;set;}

		 public string WechatUin {get;set;}

		 public int Count {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

	}
}
