using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeUserLog")]
	public partial class EmployeeUserLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeUserLogId;
             set => this.EmployeeUserLogId = value;
         }	

		 [Key]
		 public int EmployeeUserLogId {get;set;}

		 public int EmployeeId {get;set;}

		 public string UserId {get;set;}

		 public int CompanyId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
