using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeQueue")]
	public partial class EmployeeQueueEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeQueueId;
             set => this.EmployeeQueueId = value;
         }	

		 [Key]
		 public int EmployeeQueueId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
