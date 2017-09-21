using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Groups")]
	public partial class GroupsEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.GroupID;
             set => this.GroupID = value;
         }	

		 [Key]
		 public int GroupID {get;set;}

		 public string GroupName {get;set;}

		 public int ocid {get;set;}

		 public int ogid {get;set;}

		 public int IsValid {get;set;}

	}
}
