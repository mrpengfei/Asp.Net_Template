using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOrganizationDetail")]
	public partial class EmployeeOrganizationDetailEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeOrganizationDetailId;
             set => this.EmployeeOrganizationDetailId = value;
         }	

		 [Key]
		 public string EmployeeOrganizationDetailId {get;set;}

		 public string CompanyId {get;set;}

		 public string CompanyName {get;set;}

		 public string DepartmentId {get;set;}

		 public string DepartmentName {get;set;}

		 public string GroupId {get;set;}

		 public string GroupName {get;set;}

		 public string EmployeeId {get;set;}

		 public string StaffId {get;set;}

		 public string TrueName {get;set;}

		 public string Available {get;set;}

	}
}
