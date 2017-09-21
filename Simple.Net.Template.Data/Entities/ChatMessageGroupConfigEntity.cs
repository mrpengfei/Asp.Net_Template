using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatMessageGroupConfig")]
	public partial class ChatMessageGroupConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ChatMessageGroupId;
             set => this.ChatMessageGroupId = value;
         }	

		 [Key]
		 public int ChatMessageGroupId {get;set;}

		 public string ChatMessageGroupName {get;set;}

		 public string DelStatus {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
