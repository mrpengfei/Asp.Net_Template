using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserPortraitInfo")]
	public partial class UserPortraitInfoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserPortraitInfoId;
             set => this.UserPortraitInfoId = value;
         }	

		 [Key]
		 public int UserPortraitInfoId {get;set;}

		 public int UserPortraitConfigId {get;set;}

		 public string PortraitInfo {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WxUin {get;set;}

		 public string UserId {get;set;}

	}
}
