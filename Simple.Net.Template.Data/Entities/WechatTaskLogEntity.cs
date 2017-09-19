using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatTaskLog")]
	public partial class WechatTaskLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatTaskLogId;
             set => this.WechatTaskLogId = value;
         }	

		 [Key]
		 public string WechatTaskLogId {get;set;}

		 public string WechatTaskId {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string ContactInfo {get;set;}

		 public string WechatUin {get;set;}

		 public string TaskName {get;set;}

		 public string StartTime {get;set;}

		 public string TaskCreator {get;set;}

		 public string Priority {get;set;}

		 public string Result {get;set;}

		 public string Parameter {get;set;}

		 public string MainTaskId {get;set;}

		 public string Statue {get;set;}

		 public string ExtendCount {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string TaskMessage {get;set;}

		 public string WechatRemark {get;set;}

		 public string ResultDetail {get;set;}

		 public string StepDetail {get;set;}

		 public string DeviceId {get;set;}

	}
}
