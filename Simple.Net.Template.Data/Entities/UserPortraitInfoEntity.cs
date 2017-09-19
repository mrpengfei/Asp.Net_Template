using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserPortraitInfo")]
	public partial class UserPortraitInfoEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserPortraitInfoId;
             set => this.UserPortraitInfoId = value;
         }	

		 [Key]
		 public string UserPortraitInfoId {get;set;}

		 public string UserPortraitConfigId {get;set;}

		 public string PortraitInfo {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WxUin {get;set;}

		 public string UserId {get;set;}

	}
}
