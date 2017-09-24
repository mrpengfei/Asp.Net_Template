using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("OrderSplitRecord")]
	public partial class OrderSplitRecordEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.OrderSplitRecordId;
             set => this.OrderSplitRecordId = value;
         }	

		 [Key]
		 public int OrderSplitRecordId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string StaffId {get;set;}

		 public decimal Price {get;set;}

		 public DateTime CreateDate {get;set;}

		 public int OperatorId {get;set;}

	}
}
