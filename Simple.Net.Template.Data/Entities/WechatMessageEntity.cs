using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatMessage")]
	public partial class WechatMessageEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatMessageId;
             set => this.WechatMessageId = value;
         }	

		 [Key]
		 public int WechatMessageId {get;set;}

		 public string WxUin {get;set;}

		 public string ContactId {get;set;}

		 public string UserId {get;set;}

		 public string FromUser {get;set;}

		 public string ToUser {get;set;}

		 public string MessageId {get;set;}

		 public string MessageType {get;set;}

		 public string MessageContent {get;set;}

		 public DateTime MessageTime {get;set;}

		 public bool IsSendMessage {get;set;}

		 public string MessageState {get;set;}

		 public bool Result {get;set;}

		 public bool IsCancel {get;set;}

		 public bool IsChatRoom {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
