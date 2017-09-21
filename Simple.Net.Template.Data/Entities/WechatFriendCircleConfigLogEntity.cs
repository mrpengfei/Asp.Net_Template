using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatFriendCircleConfigLog")]
	public partial class WechatFriendCircleConfigLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.FriendCirckeLogId;
             set => this.FriendCirckeLogId = value;
         }	

		 [Key]
		 public int FriendCirckeLogId {get;set;}

		 public int FriendCirckeId {get;set;}

		 public string Content {get;set;}

		 public string PicUrl {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime SendTime {get;set;}

		 public int Statue {get;set;}

		 public string WechatNoInfo {get;set;}

	}
}
