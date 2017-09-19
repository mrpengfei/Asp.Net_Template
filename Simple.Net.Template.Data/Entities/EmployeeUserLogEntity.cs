using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeUserLog")]
	public partial class EmployeeUserLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeUserLogId;
             set => this.EmployeeUserLogId = value;
         }	

		 [Key]
		 public string EmployeeUserLogId {get;set;}

		 public string EmployeeId {get;set;}

		 public string UserId {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string CreateDate {get;set;}

	}
}
