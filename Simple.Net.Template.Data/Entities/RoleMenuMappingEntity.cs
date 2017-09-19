using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RoleMenuMapping")]
	public partial class RoleMenuMappingEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.RoleMenuMappingID;
             set => this.RoleMenuMappingID = value;
         }	

		 [Key]
		 public string RoleMenuMappingID {get;set;}

		 public string RoleID {get;set;}

		 public string MenuID {get;set;}

	}
}
