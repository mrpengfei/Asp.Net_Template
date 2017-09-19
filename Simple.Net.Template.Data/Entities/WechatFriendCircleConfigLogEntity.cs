using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatFriendCircleConfigLog")]
	public partial class WechatFriendCircleConfigLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.FriendCirckeLogId;
             set => this.FriendCirckeLogId = value;
         }	

		 [Key]
		 public string FriendCirckeLogId {get;set;}

		 public string FriendCirckeId {get;set;}

		 public string Content {get;set;}

		 public string PicUrl {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string SendTime {get;set;}

		 public string Statue {get;set;}

		 public string WechatNoInfo {get;set;}

	}
}
