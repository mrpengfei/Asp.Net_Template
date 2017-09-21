using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Product")]
	public partial class ProductEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ProductId;
             set => this.ProductId = value;
         }	

		 [Key]
		 public int ProductId {get;set;}

 		 public override int Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public int CompanyID {get;set;}

		 public string ProductCode {get;set;}

		 public string ProductName {get;set;}

		 public string ProductPrice {get;set;}

		 public int ProductCycle {get;set;}

 		 public override int Key
         {
             get => this.ProductCategoryId;
             set => this.ProductCategoryId = value;
         }	

		 [Key]
		 public int ProductCategoryId {get;set;}

		 public string IsDeleted {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
