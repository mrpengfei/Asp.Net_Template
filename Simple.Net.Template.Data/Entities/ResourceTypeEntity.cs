using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceType")]
	public partial class ResourceTypeEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string ResourceTypeName {get;set;}

		 public string Description {get;set;}

		 public string CompanyID {get;set;}

		 public string IsOnline {get;set;}

		 public string CreateTime {get;set;}

	}
}
