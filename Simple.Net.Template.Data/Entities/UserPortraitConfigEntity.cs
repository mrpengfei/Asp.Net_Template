using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserPortraitConfig")]
	public partial class UserPortraitConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserPortraitConfigId;
             set => this.UserPortraitConfigId = value;
         }	

		 [Key]
		 public int UserPortraitConfigId {get;set;}

		 public string PortraitName {get;set;}

		 public string DelStatus {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
