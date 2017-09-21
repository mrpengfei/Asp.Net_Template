using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Department_Company")]
	public partial class Department_CompanyEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.Department_CompanyID;
             set => this.Department_CompanyID = value;
         }	

		 [Key]
		 public int Department_CompanyID {get;set;}

		 public int DepartmentID {get;set;}

		 public int CompanyID {get;set;}

	}
}
