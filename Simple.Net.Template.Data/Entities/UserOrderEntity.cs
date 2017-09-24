using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrder")]
	public partial class UserOrderEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

		 public string UserID {get;set;}

		 public int ProduCategoryId {get;set;}

		 public int ProductId {get;set;}

		 public int OrderTypeId {get;set;}

		 public string OrderTitle {get;set;}

		 public string Description {get;set;}

		 public int OrderStateId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public decimal OrderPrice {get;set;}

		 public decimal OrderTruePrice {get;set;}

		 public int PaymentTypeId {get;set;}

		 public int EmployeeId {get;set;}

		 public string FailureReason {get;set;}

		 public string CustomerName {get;set;}

		 public string BelongTeacher {get;set;}

		 public decimal DealLine {get;set;}

		 public string IdNumber {get;set;}

		 public string QQNumber {get;set;}

		 public string Address {get;set;}

		 public string CustomerServiceNo {get;set;}

		 public string BankName {get;set;}

		 public DateTime TransactionDate {get;set;}

		 public string WechatNo {get;set;}

		 public string TradeNo {get;set;}

		 public bool IsUpdated {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public bool IsCloseOldAuthorization {get;set;}

		 public int OriginOrderProductCategoryId {get;set;}

		 public bool IsOpenAuthorization {get;set;}

		 public bool IsNew {get;set;}

		 public bool IsHasAccountApplication {get;set;}

		 public bool IsHasIncome {get;set;}

		 public int ServicesTypeId {get;set;}

		 public decimal TotalIncome {get;set;}

		 public bool IsHasAuthorizationApplication {get;set;}

		 public bool IsSignContract {get;set;}

		 public DateTime SignContractDate {get;set;}

		 public bool IsAssignedServiceEmployee {get;set;}

		 public bool IsRefund {get;set;}

		 public decimal RefundMoney {get;set;}

		 public int RefundStateId {get;set;}

	}
}
