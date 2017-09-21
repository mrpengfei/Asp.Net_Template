using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RoleMenuMapping")]
	public partial class RoleMenuMappingEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.RoleMenuMappingID;
             set => this.RoleMenuMappingID = value;
         }	

		 [Key]
		 public int RoleMenuMappingID {get;set;}

		 public int RoleID {get;set;}

		 public int MenuID {get;set;}

	}
}
