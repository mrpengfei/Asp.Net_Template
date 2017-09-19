using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTask")]
	public partial class ResourceTaskEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ResourceTaskId;
             set => this.ResourceTaskId = value;
         }	

		 [Key]
		 public string ResourceTaskId {get;set;}

		 public string ResourceId {get;set;}

		 public string EmployeeId {get;set;}

		 public string IsNew {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string ExecutionTime {get;set;}

	}
}
