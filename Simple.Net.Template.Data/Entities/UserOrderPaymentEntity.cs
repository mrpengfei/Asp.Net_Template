using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderPayment")]
	public partial class UserOrderPaymentEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderPaymentId;
             set => this.UserOrderPaymentId = value;
         }	

		 [Key]
		 public int UserOrderPaymentId {get;set;}

		 public string UserOrderNo {get;set;}

		 public int PaymentTypeId {get;set;}

		 public int PaymentBankId {get;set;}

		 public decimal PaymentMoney {get;set;}

		 public string TradeNo {get;set;}

		 public DateTime PaymentTime {get;set;}

		 public decimal ReceiveMoney {get;set;}

		 public DateTime ReceiveTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
