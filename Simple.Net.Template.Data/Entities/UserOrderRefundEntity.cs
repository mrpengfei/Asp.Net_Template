using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefund")]
	public partial class UserOrderRefundEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderRefundId;
             set => this.UserOrderRefundId = value;
         }	

		 [Key]
		 public int UserOrderRefundId {get;set;}

		 public string UserOrderNo {get;set;}

		 public decimal RefundApplyMoney {get;set;}

		 public int EmployeeId {get;set;}

		 public int PaymentTypeId {get;set;}

		 public string PaymentName {get;set;}

		 public string PaymentAccount {get;set;}

		 public string Remark {get;set;}

		 public int RefundStateId {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public string UserOrderRefundMaterialRemark {get;set;}

		 public bool IsHaveInvoice {get;set;}

		 public string IDNo {get;set;}

		 public string Phone {get;set;}

		 public decimal RefundMoney {get;set;}

	}
}
