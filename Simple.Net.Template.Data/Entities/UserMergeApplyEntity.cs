using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserMergeApply")]
	public partial class UserMergeApplyEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.id;
             set => this.id = value;
         }	

		 [Key]
		 public int id {get;set;}

		 public string PrimaryUserID {get;set;}

		 public string PrimaryTrueName {get;set;}

		 public int PrimaryUserEmployeeId {get;set;}

		 public string SecondaryUserID {get;set;}

		 public string SecondaryTrueName {get;set;}

		 public int SecondaryUserEmployeeId {get;set;}

		 public string Applicant {get;set;}

		 public DateTime ApplyTime {get;set;}

		 public int ApplyStatus {get;set;}

		 public string RejectInc {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int OperatorId {get;set;}

		 public DateTime OperateTime {get;set;}

	}
}
