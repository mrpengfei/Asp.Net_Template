using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatContactMongo")]
	public partial class WechatContactMongoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatContactMongoId;
             set => this.WechatContactMongoId = value;
         }	

		 [Key]
		 public int WechatContactMongoId {get;set;}

		 public string WxUin {get;set;}

		 public string UserId {get;set;}

		 public string WechatNo {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
