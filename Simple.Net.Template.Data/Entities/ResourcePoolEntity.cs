using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourcePool")]
	public partial class ResourcePoolEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourcePoolID;
             set => this.ResourcePoolID = value;
         }	

		 [Key]
		 public int ResourcePoolID {get;set;}

		 public int ResourceID {get;set;}

		 public int ResourceLogID {get;set;}

		 public string Handled {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
