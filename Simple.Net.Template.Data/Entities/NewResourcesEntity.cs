using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NewResources")]
	public partial class NewResourcesEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string ResourceID {get;set;}

		 public string DepartmentID {get;set;}

		 public string GroupID {get;set;}

		 public string EmployeeID {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string IsNew {get;set;}

		 public string CurrentResourceTypeID {get;set;}

		 public string CurrentResourceSubTypeID {get;set;}

	}
}
