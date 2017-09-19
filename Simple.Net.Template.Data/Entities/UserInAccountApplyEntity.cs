using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserInAccountApply")]
	public partial class UserInAccountApplyEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserInAccountApplyId;
             set => this.UserInAccountApplyId = value;
         }	

		 [Key]
		 public string UserInAccountApplyId {get;set;}

 		 public override string Key
         {
             get => this.AccountTypeId;
             set => this.AccountTypeId = value;
         }	

		 [Key]
		 public string AccountTypeId {get;set;}

		 public string IncomeMoney {get;set;}

		 public string UserId {get;set;}

 		 public override string Key
         {
             get => this.ApplyStateId;
             set => this.ApplyStateId = value;
         }	

		 [Key]
		 public string ApplyStateId {get;set;}

		 public string Description {get;set;}

		 public string AccountDetail {get;set;}

		 public string RefusalReason {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string EmployeeId {get;set;}

	}
}
