using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserInAccount")]
	public partial class UserInAccountEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserInAccountId;
             set => this.UserInAccountId = value;
         }	

		 [Key]
		 public int UserInAccountId {get;set;}

		 public int UserInAccountApplyId {get;set;}

		 public string UserId {get;set;}

		 public string ApplyMoney {get;set;}

 		 public override int Key
         {
             get => this.AccountTypeId;
             set => this.AccountTypeId = value;
         }	

		 [Key]
		 public int AccountTypeId {get;set;}

		 public string AccountMoney {get;set;}

		 public DateTime TransferDate {get;set;}

		 public string TransferName {get;set;}

		 public string TransferAccount {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public int EmployeeId {get;set;}

	}
}
