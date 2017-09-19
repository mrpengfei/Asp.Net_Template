using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatContactMongo")]
	public partial class WechatContactMongoEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatContactMongoId;
             set => this.WechatContactMongoId = value;
         }	

		 [Key]
		 public string WechatContactMongoId {get;set;}

		 public string WxUin {get;set;}

		 public string UserId {get;set;}

		 public string WechatNo {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
