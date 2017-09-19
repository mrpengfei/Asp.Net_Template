using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrder")]
	public partial class UserOrderEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

 		 public override int Key
         {
             get => this.UserID;
             set => this.UserID = value;
         }	

		 [Key]
		 public string UserID {get;set;}

 		 public override int Key
         {
             get => this.ProduCategoryId;
             set => this.ProduCategoryId = value;
         }	

		 [Key]
		 public string ProduCategoryId {get;set;}

 		 public override int Key
         {
             get => this.ProductId;
             set => this.ProductId = value;
         }	

		 [Key]
		 public string ProductId {get;set;}

 		 public override int Key
         {
             get => this.OrderTypeId;
             set => this.OrderTypeId = value;
         }	

		 [Key]
		 public string OrderTypeId {get;set;}

		 public string OrderTitle {get;set;}

		 public string Description {get;set;}

 		 public override int Key
         {
             get => this.OrderStateId;
             set => this.OrderStateId = value;
         }	

		 [Key]
		 public string OrderStateId {get;set;}

		 public string CreateTime {get;set;}

		 public string OrderPrice {get;set;}

		 public string OrderTruePrice {get;set;}

 		 public override int Key
         {
             get => this.PaymentTypeId;
             set => this.PaymentTypeId = value;
         }	

		 [Key]
		 public string PaymentTypeId {get;set;}

 		 public override int Key
         {
             get => this.EmployeeId;
             set => this.EmployeeId = value;
         }	

		 [Key]
		 public string EmployeeId {get;set;}

		 public string FailureReason {get;set;}

		 public string CustomerName {get;set;}

		 public string BelongTeacher {get;set;}

		 public string DealLine {get;set;}

		 public string IdNumber {get;set;}

		 public string QQNumber {get;set;}

		 public string Address {get;set;}

		 public string CustomerServiceNo {get;set;}

		 public string BankName {get;set;}

		 public string TransactionDate {get;set;}

		 public string WechatNo {get;set;}

		 public string TradeNo {get;set;}

		 public string IsUpdated {get;set;}

		 public string UpdateTime {get;set;}

		 public string IsCloseOldAuthorization {get;set;}

 		 public override int Key
         {
             get => this.OriginOrderProductCategoryId;
             set => this.OriginOrderProductCategoryId = value;
         }	

		 [Key]
		 public string OriginOrderProductCategoryId {get;set;}

		 public string IsOpenAuthorization {get;set;}

		 public string IsNew {get;set;}

		 public string IsHasAccountApplication {get;set;}

		 public string IsHasIncome {get;set;}

		 public string ServicesTypeId {get;set;}

		 public string TotalIncome {get;set;}

		 public string IsHasAuthorizationApplication {get;set;}

		 public string IsSignContract {get;set;}

		 public string SignContractDate {get;set;}

		 public string IsAssignedServiceEmployee {get;set;}

		 public string IsRefund {get;set;}

		 public string RefundMoney {get;set;}

 		 public override int Key
         {
             get => this.RefundStateId;
             set => this.RefundStateId = value;
         }	

		 [Key]
		 public string RefundStateId {get;set;}

	}
}