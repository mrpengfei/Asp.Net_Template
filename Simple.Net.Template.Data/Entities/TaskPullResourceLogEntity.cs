using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TaskPullResourceLog")]
	public partial class TaskPullResourceLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.TaskPullResourceLogId;
             set => this.TaskPullResourceLogId = value;
         }	

		 [Key]
		 public int TaskPullResourceLogId {get;set;}

		 public int TaskId {get;set;}

		 public int ResourceId {get;set;}

		 public string WxUin {get;set;}

		 public string AddType {get;set;}

		 public DateTime PullTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string GreetContent {get;set;}

		 public int AddTimes {get;set;}

		 public int NotPullTimes {get;set;}

		 public int AddStatus {get;set;}

		 public string Remark {get;set;}

	}
}
