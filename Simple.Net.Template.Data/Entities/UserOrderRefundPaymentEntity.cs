using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundPayment")]
	public partial class UserOrderRefundPaymentEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderRefundPaymentId;
             set => this.UserOrderRefundPaymentId = value;
         }	

		 [Key]
		 public int UserOrderRefundPaymentId {get;set;}

		 public int UserOrderRefundId {get;set;}

		 public int PaymentTypeId {get;set;}

		 public string PaymentName {get;set;}

		 public string PaymentAccount {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime PaymentDate {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public string Remark {get;set;}

		 public decimal PaymentMoney {get;set;}

	}
}
