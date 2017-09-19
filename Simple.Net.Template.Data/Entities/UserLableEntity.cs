using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserLable")]
	public partial class UserLableEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserLableId;
             set => this.UserLableId = value;
         }	

		 [Key]
		 public string UserLableId {get;set;}

		 public string UserId {get;set;}

		 public string ResourceId {get;set;}

		 public string LabelID {get;set;}

		 public string OperatorID {get;set;}

		 public string CreateTime {get;set;}

	}
}
