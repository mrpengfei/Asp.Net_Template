using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOrganizationDetail")]
	public partial class EmployeeOrganizationDetailEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeOrganizationDetailId;
             set => this.EmployeeOrganizationDetailId = value;
         }	

		 [Key]
		 public int EmployeeOrganizationDetailId {get;set;}

		 public int CompanyId {get;set;}

		 public string CompanyName {get;set;}

		 public int DepartmentId {get;set;}

		 public string DepartmentName {get;set;}

		 public int GroupId {get;set;}

		 public string GroupName {get;set;}

		 public int EmployeeId {get;set;}

		 public string StaffId {get;set;}

		 public string TrueName {get;set;}

		 public string Available {get;set;}

	}
}
