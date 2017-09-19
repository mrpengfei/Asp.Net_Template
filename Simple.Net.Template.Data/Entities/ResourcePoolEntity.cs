using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourcePool")]
	public partial class ResourcePoolEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourcePoolID;
             set => this.ResourcePoolID = value;
         }	

		 [Key]
		 public string ResourcePoolID {get;set;}

		 public string ResourceID {get;set;}

		 public string ResourceLogID {get;set;}

		 public string Handled {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
