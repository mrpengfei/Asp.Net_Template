using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourcePullAndAddWechatLog")]
	public partial class ResourcePullAndAddWechatLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatAddFriendLogId;
             set => this.WechatAddFriendLogId = value;
         }	

		 [Key]
		 public int WechatAddFriendLogId {get;set;}

		 public string WechatUin {get;set;}

		 public int ResourceId {get;set;}

		 public int AddType {get;set;}

		 public DateTime AddWechatTime {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
