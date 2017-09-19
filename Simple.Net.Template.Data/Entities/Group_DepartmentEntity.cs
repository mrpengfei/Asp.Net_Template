using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Group_Department")]
	public partial class Group_DepartmentEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.Group_DepartmentID;
             set => this.Group_DepartmentID = value;
         }	

		 [Key]
		 public string Group_DepartmentID {get;set;}

		 public string GroupID {get;set;}

		 public string DepartmentID {get;set;}

	}
}
