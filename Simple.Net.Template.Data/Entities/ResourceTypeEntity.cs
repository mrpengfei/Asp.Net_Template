using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceType")]
	public partial class ResourceTypeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public string ResourceTypeName {get;set;}

		 public string Description {get;set;}

		 public int CompanyID {get;set;}

		 public int IsOnline {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
