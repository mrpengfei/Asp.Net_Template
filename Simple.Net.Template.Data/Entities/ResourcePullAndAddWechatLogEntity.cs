using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourcePullAndAddWechatLog")]
	public partial class ResourcePullAndAddWechatLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatAddFriendLogId;
             set => this.WechatAddFriendLogId = value;
         }	

		 [Key]
		 public string WechatAddFriendLogId {get;set;}

		 public string WechatUin {get;set;}

		 public string ResourceId {get;set;}

		 public string AddType {get;set;}

		 public string AddWechatTime {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
