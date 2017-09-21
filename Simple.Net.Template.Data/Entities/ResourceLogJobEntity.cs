using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceLogJob")]
	public partial class ResourceLogJobEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceLogJobId;
             set => this.ResourceLogJobId = value;
         }	

		 [Key]
		 public int ResourceLogJobId {get;set;}

		 public string Mobile {get;set;}

		 public string ExpectJob {get;set;}

	}
}
