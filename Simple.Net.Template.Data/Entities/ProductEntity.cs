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

		 public int CompanyID {get;set;}

		 public string ProductCode {get;set;}

		 public string ProductName {get;set;}

		 public decimal ProductPrice {get;set;}

		 public int ProductCycle {get;set;}

		 public int ProductCategoryId {get;set;}

		 public bool IsDeleted {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
