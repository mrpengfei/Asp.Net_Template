using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatTask")]
	public partial class WechatTaskEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatTaskId;
             set => this.WechatTaskId = value;
         }	

		 [Key]
		 public int WechatTaskId {get;set;}

		 public string WechatNoInfo {get;set;}

		 public string ContactInfo {get;set;}

		 public string WechatUin {get;set;}

		 public string TaskName {get;set;}

		 public DateTime StartTime {get;set;}

		 public string TaskCreator {get;set;}

		 public int Priority {get;set;}

		 public string Result {get;set;}

		 public string Parameter {get;set;}

		 public int MainTaskId {get;set;}

		 public int Statue {get;set;}

		 public int ExtendCount {get;set;}

		 public string WechatRemark {get;set;}

		 public string TaskMessage {get;set;}

		 public string ResultDetail {get;set;}

	}
}
