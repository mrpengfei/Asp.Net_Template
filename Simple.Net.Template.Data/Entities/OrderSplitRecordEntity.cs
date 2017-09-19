using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("OrderSplitRecord")]
	public partial class OrderSplitRecordEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.OrderSplitRecordId;
             set => this.OrderSplitRecordId = value;
         }	

		 [Key]
		 public string OrderSplitRecordId {get;set;}

 		 public override string Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

		 public string StaffId {get;set;}

		 public string Price {get;set;}

		 public string CreateDate {get;set;}

		 public string OperatorId {get;set;}

		 public string OrderPart {get;set;}

	}
}
