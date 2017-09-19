using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderRefundMaterial")]
	public partial class UserOrderRefundMaterialEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderRefundMaterialId;
             set => this.UserOrderRefundMaterialId = value;
         }	

		 [Key]
		 public string UserOrderRefundMaterialId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserOrderRefundId {get;set;}

 		 public override string Key
         {
             get => this.MaterialTypeId;
             set => this.MaterialTypeId = value;
         }	

		 [Key]
		 public string MaterialTypeId {get;set;}

		 public string IsHave {get;set;}

		 public string MaterialNo {get;set;}

		 public string Remark {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
