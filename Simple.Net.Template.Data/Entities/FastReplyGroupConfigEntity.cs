using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("FastReplyGroupConfig")]
	public partial class FastReplyGroupConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ReplyGroupId;
             set => this.ReplyGroupId = value;
         }	

		 [Key]
		 public string ReplyGroupId {get;set;}

		 public string ReplyGroupName {get;set;}

		 public string DelStatus {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string ReplyGroupRemark {get;set;}

		 public string StaffId {get;set;}

	}
}
