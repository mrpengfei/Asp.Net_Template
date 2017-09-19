using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("FastReplyConfig")]
	public partial class FastReplyConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.FastReplyId;
             set => this.FastReplyId = value;
         }	

		 [Key]
		 public string FastReplyId {get;set;}

		 public string ReplyGroupId {get;set;}

		 public string FastReplyContent {get;set;}

		 public string FastReplyRemark {get;set;}

		 public string DelStatus {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string StaffId {get;set;}

		 public string ReplyType {get;set;}

	}
}
