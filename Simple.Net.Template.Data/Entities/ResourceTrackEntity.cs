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

		 public string ResourceID {get;set;}

		 public string BeforeEmployeeID {get;set;}

		 public string BeforeGroupID {get;set;}

		 public string BeforeUserType {get;set;}

		 public string AfterEmployeeID {get;set;}

		 public string AfterGroupID {get;set;}

		 public string AfterUserType {get;set;}

		 public string BeforeResourceType {get;set;}

		 public string AfterResourceType {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string OperatorID {get;set;}

		 public string IpAddress {get;set;}

		 public string ChangeReason {get;set;}

	}
}
