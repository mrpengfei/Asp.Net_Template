using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationRecord")]
	public partial class ViolationRecordEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ViolationRecorId;
             set => this.ViolationRecorId = value;
         }	

		 [Key]
		 public string ViolationRecorId {get;set;}

		 public string EmployeeId {get;set;}

		 public string UserId {get;set;}

		 public string ViolationKeyWordId {get;set;}

		 public string Wxuin {get;set;}

		 public string MessageId {get;set;}

		 public string MessageContent {get;set;}

		 public string MessageTime {get;set;}

		 public string ToUserName {get;set;}

		 public string HandleEmployeeId {get;set;}

		 public string HandleTime {get;set;}

		 public string HandleIpAddress {get;set;}

		 public string Remark {get;set;}

		 public string State {get;set;}

		 public string Result {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string ViolationKeyWord {get;set;}

		 public string MessageType {get;set;}

	}
}
