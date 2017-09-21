using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatMessageMongo")]
	public partial class WechatMessageMongoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatMessageMongoId;
             set => this.WechatMessageMongoId = value;
         }	

		 [Key]
		 public int WechatMessageMongoId {get;set;}

		 public string WxUin {get;set;}

		 public string UserId {get;set;}

		 public string MessageId {get;set;}

		 public string MessageType {get;set;}

		 public string MessageContent {get;set;}

		 public DateTime MessageTime {get;set;}

		 public string IsSendMessage {get;set;}

		 public string MessageWordCount {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
