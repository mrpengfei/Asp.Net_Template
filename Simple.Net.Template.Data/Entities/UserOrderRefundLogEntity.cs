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

		 public int UserOrderRefundId {get;set;}

		 public string UserOrderNo {get;set;}

		 public int EmployeeID {get;set;}

		 public int OldUserOrderRefundStateId {get;set;}

		 public int NewUserOrderRefundStateId {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
