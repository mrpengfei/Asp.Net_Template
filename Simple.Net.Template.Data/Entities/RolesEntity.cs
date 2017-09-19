using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Roles")]
	public partial class RolesEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.RoleID;
             set => this.RoleID = value;
         }	

		 [Key]
		 public string RoleID {get;set;}

		 public string RoleName {get;set;}

	}
}
