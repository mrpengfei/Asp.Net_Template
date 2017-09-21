using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddFriendConfig")]
	public partial class WechatAddFriendConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.AddFriendId;
             set => this.AddFriendId = value;
         }	

		 [Key]
		 public int AddFriendId {get;set;}

		 public string TimeBucket {get;set;}

		 public int Count {get;set;}

		 public int Sex {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int Statue {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

		 public int AddFriendType {get;set;}

	}
}
