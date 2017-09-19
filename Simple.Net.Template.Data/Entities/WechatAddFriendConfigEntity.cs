using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddFriendConfig")]
	public partial class WechatAddFriendConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.AddFriendId;
             set => this.AddFriendId = value;
         }	

		 [Key]
		 public string AddFriendId {get;set;}

		 public string TimeBucket {get;set;}

		 public string Count {get;set;}

		 public string Sex {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string Statue {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

		 public string AddFriendType {get;set;}

	}
}
