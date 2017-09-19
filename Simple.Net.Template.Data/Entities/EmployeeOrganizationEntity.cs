using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOrganization")]
	public partial class EmployeeOrganizationEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public string EmployeeID {get;set;}

		 public string CompanyID {get;set;}

		 public string DepartmentID {get;set;}

		 public string GroupID {get;set;}

	}
}
