using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeQueue")]
	public partial class EmployeeQueueEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeQueueId;
             set => this.EmployeeQueueId = value;
         }	

		 [Key]
		 public string EmployeeQueueId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateTime {get;set;}

	}
}
