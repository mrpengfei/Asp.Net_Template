using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Group_Department")]
	public partial class Group_DepartmentEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.Group_DepartmentID;
             set => this.Group_DepartmentID = value;
         }	

		 [Key]
		 public int Group_DepartmentID {get;set;}

		 public int GroupID {get;set;}

		 public int DepartmentID {get;set;}

	}
}
