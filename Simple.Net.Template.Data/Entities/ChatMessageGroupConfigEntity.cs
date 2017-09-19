using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatMessageGroupConfig")]
	public partial class ChatMessageGroupConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ChatMessageGroupId;
             set => this.ChatMessageGroupId = value;
         }	

		 [Key]
		 public string ChatMessageGroupId {get;set;}

		 public string ChatMessageGroupName {get;set;}

		 public string DelStatus {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
