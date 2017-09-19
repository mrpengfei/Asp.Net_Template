using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddFriendTesters")]
	public partial class WechatAddFriendTestersEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatAddFriendTestersId;
             set => this.WechatAddFriendTestersId = value;
         }	

		 [Key]
		 public string WechatAddFriendTestersId {get;set;}

		 public string UserID {get;set;}

		 public string ResourceId {get;set;}

		 public string Mobile {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

	}
}
