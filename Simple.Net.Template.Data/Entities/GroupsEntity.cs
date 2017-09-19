using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Groups")]
	public partial class GroupsEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.GroupID;
             set => this.GroupID = value;
         }	

		 [Key]
		 public string GroupID {get;set;}

		 public string GroupName {get;set;}

		 public string ocid {get;set;}

		 public string ogid {get;set;}

		 public string IsValid {get;set;}

	}
}
