using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WeChatRcontact")]
	public partial class WeChatRcontactEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WeChatRcontactId;
             set => this.WeChatRcontactId = value;
         }	

		 [Key]
		 public int WeChatRcontactId {get;set;}

		 public string username {get;set;}

		 public string alias {get;set;}

		 public string conRemark {get;set;}

		 public string nickname {get;set;}

		 public int deleteFlag {get;set;}

		 public DateTime CreateDate {get;set;}

		 public string wechatUid {get;set;}

		 public bool handle {get;set;}

		 public string UserId {get;set;}

		 public bool ImportPool {get;set;}

		 public bool AddRemark {get;set;}

		 public int Type {get;set;}

	}
}
