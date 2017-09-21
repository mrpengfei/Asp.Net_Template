using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ProductCategory")]
	public partial class ProductCategoryEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ProductCategoryId;
             set => this.ProductCategoryId = value;
         }	

		 [Key]
		 public int ProductCategoryId {get;set;}

 		 public override int Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public int CompanyID {get;set;}

		 public string ProductCategoryName {get;set;}

		 public string ProductCategoryCode {get;set;}

		 public string ProductCategoryDescription {get;set;}

		 public string IsDeleted {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
