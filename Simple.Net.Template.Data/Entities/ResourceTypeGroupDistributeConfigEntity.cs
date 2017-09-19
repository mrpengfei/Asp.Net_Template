using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTypeGroupDistributeConfig")]
	public partial class ResourceTypeGroupDistributeConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceTypeGroupDistributeConfigID;
             set => this.ResourceTypeGroupDistributeConfigID = value;
         }	

		 [Key]
		 public string ResourceTypeGroupDistributeConfigID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string GroupID {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
