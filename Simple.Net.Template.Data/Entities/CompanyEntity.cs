using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Company")]
	public partial class CompanyEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.CompanyID;
             set => this.CompanyID = value;
         }	

		 [Key]
		 public string CompanyID {get;set;}

		 public string CompanyName {get;set;}

		 public string ocid {get;set;}

	}
}
