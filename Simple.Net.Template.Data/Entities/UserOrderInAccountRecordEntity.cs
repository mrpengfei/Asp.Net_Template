using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderInAccountRecord")]
	public partial class UserOrderInAccountRecordEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderInAccountRecordId;
             set => this.UserOrderInAccountRecordId = value;
         }	

		 [Key]
		 public string UserOrderInAccountRecordId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public string ApplyMoney {get;set;}

 		 public override string Key
         {
             get => this.AccountTypeId;
             set => this.AccountTypeId = value;
         }	

		 [Key]
		 public string AccountTypeId {get;set;}

		 public string AccountMoney {get;set;}

		 public string TransferDate {get;set;}

		 public string TransferName {get;set;}

		 public string TransferAccount {get;set;}

		 public string Description {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string UserOrderInAccountApplyId {get;set;}

	}
}
