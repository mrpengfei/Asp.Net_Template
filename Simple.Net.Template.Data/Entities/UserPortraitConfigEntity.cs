using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserPortraitConfig")]
	public partial class UserPortraitConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserPortraitConfigId;
             set => this.UserPortraitConfigId = value;
         }	

		 [Key]
		 public string UserPortraitConfigId {get;set;}

		 public string PortraitName {get;set;}

		 public string DelStatus {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
