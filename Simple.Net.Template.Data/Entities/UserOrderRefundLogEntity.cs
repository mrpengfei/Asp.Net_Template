using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundLog")]
	public partial class UserOrderRefundLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderRefundLogId;
             set => this.UserOrderRefundLogId = value;
         }	

		 [Key]
		 public int UserOrderRefundLogId {get;set;}

 		 public override int Key
         {
             get => this.UserOrderRefundId;
             set => this.UserOrderRefundId = value;
         }	

		 [Key]
		 public int UserOrderRefundId {get;set;}

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
		 public int EmployeeID {get;set;}

 		 public override int Key
         {
             get => this.OldUserOrderRefundStateId;
             set => this.OldUserOrderRefundStateId = value;
         }	

		 [Key]
		 public int OldUserOrderRefundStateId {get;set;}

 		 public override int Key
         {
             get => this.NewUserOrderRefundStateId;
             set => this.NewUserOrderRefundStateId = value;
         }	

		 [Key]
		 public int NewUserOrderRefundStateId {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
