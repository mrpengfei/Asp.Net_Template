using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceDistribute")]
	public partial class ResourceDistributeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.Id;
             set => this.Id = value;
         }	

		 [Key]
		 public int Id {get;set;}

		 public string Url {get;set;}

		 public string Parameter {get;set;}

		 public string Result {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
