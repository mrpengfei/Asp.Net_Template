using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceAssignLog")]
	public partial class ResourceAssignLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceAssignLogId;
             set => this.ResourceAssignLogId = value;
         }	

		 [Key]
		 public string ResourceAssignLogId {get;set;}

		 public string ResourceId {get;set;}

		 public string EmployeeId {get;set;}

		 public string OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public string AssignDate {get;set;}

		 public string CreateTime {get;set;}

	}
}
