using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupContactMongo")]
	public partial class WechatGroupContactMongoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatGroupContactMongoId;
             set => this.WechatGroupContactMongoId = value;
         }	

		 [Key]
		 public int WechatGroupContactMongoId {get;set;}

		 public string WxUin {get;set;}

		 public string NickName {get;set;}

		 public string UserName {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
