using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RoleEmployeeMapping")]
	public partial class RoleEmployeeMappingEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.RoleEmployeeMappingID;
             set => this.RoleEmployeeMappingID = value;
         }	

		 [Key]
		 public string RoleEmployeeMappingID {get;set;}

		 public string RoleID {get;set;}

		 public string EmployeeID {get;set;}

	}
}
