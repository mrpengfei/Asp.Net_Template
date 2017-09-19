using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ShareResource")]
	public partial class ShareResourceEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string ResourceID {get;set;}

		 public string EmployeeID {get;set;}

		 public string ShareEmployeeID {get;set;}

		 public string Status {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
