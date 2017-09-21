using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceTypeGroupDistributeConfig")]
	public partial class ResourceTypeGroupDistributeConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceTypeGroupDistributeConfigID;
             set => this.ResourceTypeGroupDistributeConfigID = value;
         }	

		 [Key]
		 public int ResourceTypeGroupDistributeConfigID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public int GroupID {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
