using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTaskLog")]
	public partial class ResourceTaskLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ResourceTaskLogId;
             set => this.ResourceTaskLogId = value;
         }	

		 [Key]
		 public string ResourceTaskLogId {get;set;}

		 public string ResourceId {get;set;}

		 public string EmployeeId {get;set;}

		 public string IsNew {get;set;}

		 public string TaskAddTime {get;set;}

		 public string ExecutionTime {get;set;}

		 public string CreateTime {get;set;}

	}
}
