using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundPayment")]
	public partial class UserOrderRefundPaymentEntity : BaseEntity<string>
	{
		 public string UserOrderRefundId {get;set;}

 		 public override string Key
         {
             get => this.PaymentTypeId;
             set => this.PaymentTypeId = value;
         }	

		 [Key]
		 public string PaymentTypeId {get;set;}

		 public string PaymentName {get;set;}

		 public string PaymentAccount {get;set;}

		 public string EmployeeId {get;set;}

		 public string PaymentDate {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string Remark {get;set;}

		 public string PaymentMoney {get;set;}

 		 public override string Key
         {
             get => this.UserOrderRefundPaymentId;
             set => this.UserOrderRefundPaymentId = value;
         }	

		 [Key]
		 public string UserOrderRefundPaymentId {get;set;}

	}
}
