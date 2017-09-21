using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserType")]
	public partial class UserTypeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserTypeID;
             set => this.UserTypeID = value;
         }	

		 [Key]
		 public int UserTypeID {get;set;}

		 public string UserTypeName {get;set;}

	}
}
