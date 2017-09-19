using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ProductCategory")]
	public partial class ProductCategoryEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ProductCategoryId;
             set => this.ProductCategoryId = value;
         }	

		 [Key]
		 public string ProductCategoryId {get;set;}

 		 public override string Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public string CompanyID {get;set;}

		 public string ProductCategoryName {get;set;}

		 public string ProductCategoryCode {get;set;}

		 public string ProductCategoryDescription {get;set;}

		 public string IsDeleted {get;set;}

		 public string CreateTime {get;set;}

	}
}
