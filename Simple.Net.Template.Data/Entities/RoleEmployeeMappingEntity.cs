using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RoleEmployeeMapping")]
	public partial class RoleEmployeeMappingEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.RoleEmployeeMappingID;
             set => this.RoleEmployeeMappingID = value;
         }	

		 [Key]
		 public int RoleEmployeeMappingID {get;set;}

		 public int RoleID {get;set;}

		 public int EmployeeID {get;set;}

	}
}
