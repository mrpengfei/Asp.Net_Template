using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TaskPullResourceLog")]
	public partial class TaskPullResourceLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.TaskPullResourceLogId;
             set => this.TaskPullResourceLogId = value;
         }	

		 [Key]
		 public string TaskPullResourceLogId {get;set;}

		 public string TaskId {get;set;}

		 public string ResourceId {get;set;}

		 public string WxUin {get;set;}

		 public string PullTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string GreetContent {get;set;}

		 public string AddTimes {get;set;}

		 public string NotPullTimes {get;set;}

		 public string AddStatus {get;set;}

		 public string Remark {get;set;}

		 public string DeviceId {get;set;}

		 public string AddType {get;set;}

	}
}
