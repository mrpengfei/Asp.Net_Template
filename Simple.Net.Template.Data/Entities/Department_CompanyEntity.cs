using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Department_Company")]
	public partial class Department_CompanyEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.Department_CompanyID;
             set => this.Department_CompanyID = value;
         }	

		 [Key]
		 public string Department_CompanyID {get;set;}

		 public string DepartmentID {get;set;}

		 public string CompanyID {get;set;}

	}
}
