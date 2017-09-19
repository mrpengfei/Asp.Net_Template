using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTypeEmployeeDistributeConfig")]
	public partial class ResourceTypeEmployeeDistributeConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ResourceTypeEmployeeDistributeConfigId;
             set => this.ResourceTypeEmployeeDistributeConfigId = value;
         }	

		 [Key]
		 public string ResourceTypeEmployeeDistributeConfigId {get;set;}

		 public string ResourceSubTypeId {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string GroupId {get;set;}

	}
}
