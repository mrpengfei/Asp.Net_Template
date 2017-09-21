using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserFunds")]
	public partial class UserFundsEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserFundsId;
             set => this.UserFundsId = value;
         }	

		 [Key]
		 public int UserFundsId {get;set;}

		 public string UserID {get;set;}

		 public string TotalMoney {get;set;}

		 public string AvailableMoney {get;set;}

		 public string FrozenMoney {get;set;}

		 public string LatelyIncomeMoney {get;set;}

		 public DateTime LatelyIncomeDate {get;set;}

		 public string LatelyPurchaseMoney {get;set;}

		 public DateTime LatelyPurchaseDate {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
