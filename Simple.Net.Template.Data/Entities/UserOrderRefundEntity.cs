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

		 public string RefundApplyMoney {get;set;}

		 public int EmployeeId {get;set;}

 		 public override int Key
         {
             get => this.PaymentTypeId;
             set => this.PaymentTypeId = value;
         }	

		 [Key]
		 public int PaymentTypeId {get;set;}

		 public string PaymentName {get;set;}

		 public string PaymentAccount {get;set;}

		 public string Remark {get;set;}

 		 public override int Key
         {
             get => this.RefundStateId;
             set => this.RefundStateId = value;
         }	

		 [Key]
		 public int RefundStateId {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public string UserOrderRefundMaterialRemark {get;set;}

		 public string IsHaveInvoice {get;set;}

		 public string IDNo {get;set;}

		 public string Phone {get;set;}

		 public string RefundMoney {get;set;}

	}
}
