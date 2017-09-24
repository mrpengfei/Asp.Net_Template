using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundMaterial")]
	public partial class UserOrderRefundMaterialEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderRefundMaterialId;
             set => this.UserOrderRefundMaterialId = value;
         }	

		 [Key]
		 public int UserOrderRefundMaterialId {get;set;}

		 public string UserOrderNo {get;set;}

		 public int UserOrderRefundId {get;set;}

		 public int MaterialTypeId {get;set;}

		 public bool IsHave {get;set;}

		 public string MaterialNo {get;set;}

		 public string Remark {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
