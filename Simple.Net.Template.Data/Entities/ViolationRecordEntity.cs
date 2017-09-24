using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationRecord")]
	public partial class ViolationRecordEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ViolationRecorId;
             set => this.ViolationRecorId = value;
         }	

		 [Key]
		 public int ViolationRecorId {get;set;}

		 public int EmployeeId {get;set;}

		 public string UserId {get;set;}

		 public int ViolationKeyWordId {get;set;}

		 public string Wxuin {get;set;}

		 public string MessageId {get;set;}

		 public string MessageContent {get;set;}

		 public DateTime MessageTime {get;set;}

		 public string ToUserName {get;set;}

		 public int HandleEmployeeId {get;set;}

		 public DateTime HandleTime {get;set;}

		 public string HandleIpAddress {get;set;}

		 public string Remark {get;set;}

		 public bool State {get;set;}

		 public int Result {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string ViolationKeyWord {get;set;}

		 public string MessageType {get;set;}

	}
}
