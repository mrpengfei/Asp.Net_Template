using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundLog")]
	public partial class UserOrderRefundLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserOrderRefundLogId;
             set => this.UserOrderRefundLogId = value;
         }	

		 [Key]
		 public string UserOrderRefundLogId {get;set;}

 		 public override int Key
         {
             get => this.UserOrderRefundId;
             set => this.UserOrderRefundId = value;
         }	

		 [Key]
		 public string UserOrderRefundId {get;set;}

 		 public override int Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

 		 public override int Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public string EmployeeID {get;set;}

 		 public override int Key
         {
             get => this.OldUserOrderRefundStateId;
             set => this.OldUserOrderRefundStateId = value;
         }	

		 [Key]
		 public string OldUserOrderRefundStateId {get;set;}

 		 public override int Key
         {
             get => this.NewUserOrderRefundStateId;
             set => this.NewUserOrderRefundStateId = value;
         }	

		 [Key]
		 public string NewUserOrderRefundStateId {get;set;}

		 public string Description {get;set;}

		 public string CreateTime {get;set;}

	}
}
