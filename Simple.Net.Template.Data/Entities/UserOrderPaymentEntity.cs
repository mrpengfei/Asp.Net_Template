using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderPayment")]
	public partial class UserOrderPaymentEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserOrderPaymentId;
             set => this.UserOrderPaymentId = value;
         }	

		 [Key]
		 public string UserOrderPaymentId {get;set;}

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
		 public string PaymentTypeId {get;set;}

 		 public override int Key
         {
             get => this.PaymentBankId;
             set => this.PaymentBankId = value;
         }	

		 [Key]
		 public string PaymentBankId {get;set;}

		 public string PaymentMoney {get;set;}

		 public string TradeNo {get;set;}

		 public string PaymentTime {get;set;}

		 public string ReceiveMoney {get;set;}

		 public string ReceiveTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
