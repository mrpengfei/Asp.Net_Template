using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddFriendConfigLog")]
	public partial class WechatAddFriendConfigLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.AddFriendLogId;
             set => this.AddFriendLogId = value;
         }	

		 [Key]
		 public string AddFriendLogId {get;set;}

		 public string AddFriendId {get;set;}

		 public string TimeBucket {get;set;}

		 public string Count {get;set;}

		 public string Sex {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string Statue {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

	}
}
