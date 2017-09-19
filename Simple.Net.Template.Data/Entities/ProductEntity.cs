using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Product")]
	public partial class ProductEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ProductId;
             set => this.ProductId = value;
         }	

		 [Key]
		 public string ProductId {get;set;}

 		 public override int Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public string CompanyID {get;set;}

		 public string ProductCode {get;set;}

		 public string ProductName {get;set;}

		 public string ProductPrice {get;set;}

		 public string ProductCycle {get;set;}

 		 public override int Key
         {
             get => this.ProductCategoryId;
             set => this.ProductCategoryId = value;
         }	

		 [Key]
		 public string ProductCategoryId {get;set;}

		 public string IsDeleted {get;set;}

		 public string CreateTime {get;set;}

	}
}
