using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatRcontact")]
	public partial class WeChatRcontactEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WeChatRcontactId;
             set => this.WeChatRcontactId = value;
         }	

		 [Key]
		 public string WeChatRcontactId {get;set;}

		 public string username {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public string deleteFlag {get;set;}

		 public string CreateDate {get;set;}

		 public string wechatUid {get;set;}

		 public string handle {get;set;}

		 public string UserId {get;set;}

		 public string ImportPool {get;set;}

		 public string AddRemark {get;set;}

		 public string Type {get;set;}

	}
}
