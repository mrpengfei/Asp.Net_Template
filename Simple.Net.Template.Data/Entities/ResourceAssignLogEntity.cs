using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceAssignLog")]
	public partial class ResourceAssignLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceAssignLogId;
             set => this.ResourceAssignLogId = value;
         }	

		 [Key]
		 public int ResourceAssignLogId {get;set;}

		 public int ResourceId {get;set;}

		 public int EmployeeId {get;set;}

		 public int OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public string AssignDate {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
