using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTaskLog")]
	public partial class ResourceTaskLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceTaskLogId;
             set => this.ResourceTaskLogId = value;
         }	

		 [Key]
		 public int ResourceTaskLogId {get;set;}

		 public int ResourceId {get;set;}

		 public int EmployeeId {get;set;}

		 public bool IsNew {get;set;}

		 public DateTime TaskAddTime {get;set;}

		 public DateTime ExecutionTime {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
