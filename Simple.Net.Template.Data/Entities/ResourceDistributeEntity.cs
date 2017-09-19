using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceDistribute")]
	public partial class ResourceDistributeEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.Id;
             set => this.Id = value;
         }	

		 [Key]
		 public string Id {get;set;}

		 public string Url {get;set;}

		 public string Parameter {get;set;}

		 public string Result {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
