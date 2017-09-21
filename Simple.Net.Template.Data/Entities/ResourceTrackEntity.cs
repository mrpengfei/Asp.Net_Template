using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTrack")]
	public partial class ResourceTrackEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceTrackID;
             set => this.ResourceTrackID = value;
         }	

		 [Key]
		 public string ResourceTrackID {get;set;}

		 public int ResourceID {get;set;}

		 public int BeforeEmployeeID {get;set;}

		 public int BeforeGroupID {get;set;}

		 public string BeforeUserType {get;set;}

		 public int AfterEmployeeID {get;set;}

		 public int AfterGroupID {get;set;}

		 public string AfterUserType {get;set;}

		 public string BeforeResourceType {get;set;}

		 public string AfterResourceType {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int OperatorID {get;set;}

		 public string IpAddress {get;set;}

		 public string ChangeReason {get;set;}

		 public int BeforeDepartmentID {get;set;}

		 public int BeforeCompanyID {get;set;}

		 public int AfterDepartmentID {get;set;}

		 public int AfterCompanyID {get;set;}

	}
}
