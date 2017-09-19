using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatMessageConfig")]
	public partial class ChatMessageConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ChatMessageId;
             set => this.ChatMessageId = value;
         }	

		 [Key]
		 public string ChatMessageId {get;set;}

		 public string ChatMessageGroupId {get;set;}

		 public string ChatMessageContent {get;set;}

		 public string DelStatus {get;set;}

		 public string ChatMessageType {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
