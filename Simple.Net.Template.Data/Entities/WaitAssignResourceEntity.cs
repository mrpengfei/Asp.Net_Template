using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WaitAssignResource")]
	public partial class WaitAssignResourceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WaitAssignResourceId;
             set => this.WaitAssignResourceId = value;
         }	

		 [Key]
		 public int WaitAssignResourceId {get;set;}

		 public int ResourceId {get;set;}

		 public string IsWait {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
