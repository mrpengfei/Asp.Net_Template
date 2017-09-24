using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserInAccountApply")]
	public partial class UserInAccountApplyEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserInAccountApplyId;
             set => this.UserInAccountApplyId = value;
         }	

		 [Key]
		 public int UserInAccountApplyId {get;set;}

		 public int AccountTypeId {get;set;}

		 public string IncomeMoney {get;set;}

		 public string UserId {get;set;}

		 public int ApplyStateId {get;set;}

		 public string Description {get;set;}

		 public string AccountDetail {get;set;}

		 public string RefusalReason {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public int EmployeeId {get;set;}

	}
}
