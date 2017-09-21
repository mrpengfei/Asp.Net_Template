using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("FastReplyConfig")]
	public partial class FastReplyConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.FastReplyId;
             set => this.FastReplyId = value;
         }	

		 [Key]
		 public int FastReplyId {get;set;}

		 public int ReplyGroupId {get;set;}

		 public string FastReplyContent {get;set;}

		 public string FastReplyRemark {get;set;}

		 public string DelStatus {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string StaffId {get;set;}

		 public int ReplyType {get;set;}

	}
}
