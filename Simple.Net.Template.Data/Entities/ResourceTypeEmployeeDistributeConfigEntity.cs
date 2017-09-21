using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTypeEmployeeDistributeConfig")]
	public partial class ResourceTypeEmployeeDistributeConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceTypeEmployeeDistributeConfigId;
             set => this.ResourceTypeEmployeeDistributeConfigId = value;
         }	

		 [Key]
		 public int ResourceTypeEmployeeDistributeConfigId {get;set;}

		 public int ResourceSubTypeId {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int GroupId {get;set;}

	}
}
