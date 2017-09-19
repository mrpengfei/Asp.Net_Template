using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserMergeApply")]
	public partial class UserMergeApplyEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.id;
             set => this.id = value;
         }	

		 [Key]
		 public string id {get;set;}

		 public string PrimaryUserID {get;set;}

		 public string PrimaryTrueName {get;set;}

		 public string PrimaryUserEmployeeId {get;set;}

		 public string SecondaryUserID {get;set;}

		 public string SecondaryTrueName {get;set;}

		 public string SecondaryUserEmployeeId {get;set;}

		 public string Applicant {get;set;}

		 public string ApplyTime {get;set;}

		 public string ApplyStatus {get;set;}

		 public string RejectInc {get;set;}

		 public string UpdateTime {get;set;}

		 public string OperatorId {get;set;}

		 public string OperateTime {get;set;}

	}
}
