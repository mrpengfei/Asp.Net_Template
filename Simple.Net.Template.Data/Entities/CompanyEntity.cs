using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Company")]
	public partial class CompanyEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public int CompanyID {get;set;}

		 public string CompanyName {get;set;}

		 public int ocid {get;set;}

	}
}
