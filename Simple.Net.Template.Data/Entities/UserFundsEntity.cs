using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserFunds")]
	public partial class UserFundsEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserFundsId;
             set => this.UserFundsId = value;
         }	

		 [Key]
		 public string UserFundsId {get;set;}

		 public string UserID {get;set;}

		 public string TotalMoney {get;set;}

		 public string AvailableMoney {get;set;}

		 public string FrozenMoney {get;set;}

		 public string LatelyIncomeMoney {get;set;}

		 public string LatelyIncomeDate {get;set;}

		 public string LatelyPurchaseMoney {get;set;}

		 public string LatelyPurchaseDate {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
