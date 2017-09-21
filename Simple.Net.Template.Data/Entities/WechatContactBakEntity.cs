using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatContactBak")]
	public partial class WechatContactBakEntity : BaseEntity<int>
	{
		 public int WechatContactBakId {get;set;}

		 public string username {get;set;}

		 public string wxusername {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public string UserId {get;set;}

		 public string WxUin {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
