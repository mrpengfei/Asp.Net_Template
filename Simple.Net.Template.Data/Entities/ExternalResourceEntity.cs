using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ExternalResource")]
	public partial class ExternalResourceEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ExternalResourceId;
             set => this.ExternalResourceId = value;
         }	

		 [Key]
		 public string ExternalResourceId {get;set;}

		 public string ResourceId {get;set;}

		 public string UserId {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string ResourceSubTypeId {get;set;}

		 public string RegisterTime {get;set;}

	}
}
