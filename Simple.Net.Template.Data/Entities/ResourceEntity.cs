using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Resource")]
	public partial class ResourceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceID;
             set => this.ResourceID = value;
         }	

		 [Key]
		 public string ResourceID {get;set;}

		 public string ResourceName {get;set;}

		 public string ContactInfo {get;set;}

		 public string ResourceTypeID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string UserID {get;set;}

		 public string IsNew {get;set;}

		 public string Recycle {get;set;}

		 public string ResourceTagID {get;set;}

		 public string ResourceStatus {get;set;}

		 public string CreateTime {get;set;}

		 public string Updatetime {get;set;}

		 public string CompanyID {get;set;}

		 public string CurrentResourceTypeID {get;set;}

		 public string CurrentResourceSubTypeID {get;set;}

		 public string CurrentLogID {get;set;}

		 public string ResourceSubPartID {get;set;}

		 public string GroupID {get;set;}

		 public string DepartmentID {get;set;}

	}
}
