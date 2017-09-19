using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceSubType")]
	public partial class ResourceSubTypeEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string ResourceTypeID {get;set;}

		 public string ResourceSubTypeName {get;set;}

		 public string Description {get;set;}

		 public string HandleClass {get;set;}

		 public string ImportPoolClass {get;set;}

		 public string DistributeClass {get;set;}

		 public string ActionID {get;set;}

		 public string ActionURL {get;set;}

		 public string ActionMemo {get;set;}

		 public string ActionFilePath {get;set;}

		 public string CreateTime {get;set;}

		 public string IsOnline {get;set;}

		 public string UpdateTime {get;set;}

	}
}
