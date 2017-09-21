using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Resource")]
	public partial class ResourceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceID;
             set => this.ResourceID = value;
         }	

		 [Key]
		 public int ResourceID {get;set;}

		 public string ResourceName {get;set;}

		 public string ContactInfo {get;set;}

		 public int ResourceTypeID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public string UserID {get;set;}

		 public string IsNew {get;set;}

		 public string Recycle {get;set;}

		 public string ResourceTagID {get;set;}

		 public int ResourceStatus {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime Updatetime {get;set;}

		 public int CompanyID {get;set;}

		 public int CurrentResourceTypeID {get;set;}

		 public int CurrentResourceSubTypeID {get;set;}

		 public int CurrentLogID {get;set;}

		 public int ResourceSubPartID {get;set;}

		 public int GroupID {get;set;}

		 public int DepartmentID {get;set;}

		 public int OperatorID {get;set;}

	}
}
