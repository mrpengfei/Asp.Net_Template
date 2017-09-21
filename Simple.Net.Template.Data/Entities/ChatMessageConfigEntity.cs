using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatMessageConfig")]
	public partial class ChatMessageConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ChatMessageId;
             set => this.ChatMessageId = value;
         }	

		 [Key]
		 public int ChatMessageId {get;set;}

		 public int ChatMessageGroupId {get;set;}

		 public string ChatMessageContent {get;set;}

		 public string DelStatus {get;set;}

		 public int ChatMessageType {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
