using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserExt")]
	public partial class UserExtEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserExtId;
             set => this.UserExtId = value;
         }	

		 [Key]
		 public int UserExtId {get;set;}

		 public string Integral {get;set;}

		 public int Level {get;set;}

		 public DateTime LastLoginTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public string UserID {get;set;}

		 public DateTime RegisterTime {get;set;}

		 public string UserName {get;set;}

		 public string ContactInfo {get;set;}

	}
}
