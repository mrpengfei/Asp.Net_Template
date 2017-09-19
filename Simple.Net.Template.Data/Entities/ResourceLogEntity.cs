using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceLog")]
	public partial class ResourceLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceLogID;
             set => this.ResourceLogID = value;
         }	

		 [Key]
		 public string ResourceLogID {get;set;}

		 public string Mobile {get;set;}

		 public string ResourceContent {get;set;}

		 public string ImportTime {get;set;}

		 public string ResourceID {get;set;}

		 public string ResourceTypeID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string NeeAddMemo {get;set;}

		 public string Handled {get;set;}

		 public string ImprotedPool {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string EmployeeID {get;set;}

		 public string IsNew {get;set;}

		 public string GroupID {get;set;}

		 public string ResourceSubPartID {get;set;}

		 public string ContactTypeId {get;set;}

		 public string MobileMd5 {get;set;}

	}
}
