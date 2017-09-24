using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTask")]
	public partial class ResourceTaskEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceTaskId;
             set => this.ResourceTaskId = value;
         }	

		 [Key]
		 public int ResourceTaskId {get;set;}

		 public int ResourceId {get;set;}

		 public int EmployeeId {get;set;}

		 public bool IsNew {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime ExecutionTime {get;set;}

	}
}
