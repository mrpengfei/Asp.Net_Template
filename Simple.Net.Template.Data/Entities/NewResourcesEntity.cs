using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NewResources")]
	public partial class NewResourcesEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public int ResourceID {get;set;}

		 public int DepartmentID {get;set;}

		 public int GroupID {get;set;}

		 public int EmployeeID {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public bool IsNew {get;set;}

		 public int CurrentResourceTypeID {get;set;}

		 public int CurrentResourceSubTypeID {get;set;}

	}
}
