using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupContactMemberMongo")]
	public partial class WechatGroupContactMemberMongoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatGroupContactMemberMongoId;
             set => this.WechatGroupContactMemberMongoId = value;
         }	

		 [Key]
		 public int WechatGroupContactMemberMongoId {get;set;}

		 public string WxUin {get;set;}

		 public string NickName {get;set;}

		 public string WechatNo {get;set;}

		 public string RemarkName {get;set;}

		 public string GroupUserName {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
