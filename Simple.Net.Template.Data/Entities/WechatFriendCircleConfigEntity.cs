using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatFriendCircleConfig")]
	public partial class WechatFriendCircleConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.FriendCircleId;
             set => this.FriendCircleId = value;
         }	

		 [Key]
		 public string FriendCircleId {get;set;}

		 public string Content {get;set;}

		 public string PicUrl {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string SendTime {get;set;}

		 public string Statue {get;set;}

		 public string WechatNoInfo {get;set;}

	}
}
