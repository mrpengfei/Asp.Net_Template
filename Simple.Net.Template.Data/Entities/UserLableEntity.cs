using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserLable")]
	public partial class UserLableEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserLableId;
             set => this.UserLableId = value;
         }	

		 [Key]
		 public int UserLableId {get;set;}

		 public string UserId {get;set;}

		 public int ResourceId {get;set;}

		 public int LabelID {get;set;}

		 public int OperatorID {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
