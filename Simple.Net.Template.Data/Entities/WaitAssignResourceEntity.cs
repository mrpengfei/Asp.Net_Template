using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WaitAssignResource")]
	public partial class WaitAssignResourceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WaitAssignResourceId;
             set => this.WaitAssignResourceId = value;
         }	

		 [Key]
		 public string WaitAssignResourceId {get;set;}

		 public string ResourceId {get;set;}

		 public string IsWait {get;set;}

		 public string UpdateTime {get;set;}

		 public string CreateTime {get;set;}

	}
}
