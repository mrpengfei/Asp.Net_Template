using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOrganization")]
	public partial class EmployeeOrganizationEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public int EmployeeID {get;set;}

		 public int CompanyID {get;set;}

		 public int DepartmentID {get;set;}

		 public int GroupID {get;set;}

	}
}
