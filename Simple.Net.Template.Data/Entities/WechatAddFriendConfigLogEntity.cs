using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddFriendConfigLog")]
	public partial class WechatAddFriendConfigLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.AddFriendLogId;
             set => this.AddFriendLogId = value;
         }	

		 [Key]
		 public int AddFriendLogId {get;set;}

		 public int AddFriendId {get;set;}

		 public string TimeBucket {get;set;}

		 public int Count {get;set;}

		 public int Sex {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatNoInfo {get;set;}

		 public int Statue {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

	}
}
