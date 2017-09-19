using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserType")]
	public partial class UserTypeEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserTypeID;
             set => this.UserTypeID = value;
         }	

		 [Key]
		 public string UserTypeID {get;set;}

		 public string UserTypeName {get;set;}

		 public string OrderSize {get;set;}

		 public string IsBack {get;set;}

	}
}
