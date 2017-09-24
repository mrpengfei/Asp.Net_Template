using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderInAccountRecord")]
	public partial class UserOrderInAccountRecordEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderInAccountRecordId;
             set => this.UserOrderInAccountRecordId = value;
         }	

		 [Key]
		 public int UserOrderInAccountRecordId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public string ApplyMoney {get;set;}

		 public int AccountTypeId {get;set;}

		 public string AccountMoney {get;set;}

		 public DateTime TransferDate {get;set;}

		 public string TransferName {get;set;}

		 public string TransferAccount {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public int UserOrderInAccountApplyId {get;set;}

	}
}
