using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatSearchAddFriendConfig")]
	public partial class WechatSearchAddFriendConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatSearchAddFriendConfigId;
             set => this.WechatSearchAddFriendConfigId = value;
         }	

		 [Key]
		 public string WechatSearchAddFriendConfigId {get;set;}

		 public string WechatUin {get;set;}

		 public string Count {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

	}
}
