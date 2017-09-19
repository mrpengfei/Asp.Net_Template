using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserExt")]
	public partial class UserExtEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserExtId;
             set => this.UserExtId = value;
         }	

		 [Key]
		 public string UserExtId {get;set;}

		 public string Integral {get;set;}

		 public string Level {get;set;}

		 public string LastLoginTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UserID {get;set;}

		 public string RegisterTime {get;set;}

		 public string UserName {get;set;}

		 public string ContactInfo {get;set;}

	}
}
