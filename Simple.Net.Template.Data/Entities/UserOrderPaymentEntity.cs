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

 		 public override int Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

 		 public override int Key
         {
             get => this.PaymentTypeId;
             set => this.PaymentTypeId = value;
         }	

		 [Key]
		 public int PaymentTypeId {get;set;}

 		 public override int Key
         {
             get => this.PaymentBankId;
             set => this.PaymentBankId = value;
         }	

		 [Key]
		 public int PaymentBankId {get;set;}

		 public string PaymentMoney {get;set;}

		 public string TradeNo {get;set;}

		 public DateTime PaymentTime {get;set;}

		 public string ReceiveMoney {get;set;}

		 public DateTime ReceiveTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
