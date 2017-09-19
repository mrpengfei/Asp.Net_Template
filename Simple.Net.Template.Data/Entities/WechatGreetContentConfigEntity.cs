using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGreetContentConfig")]
	public partial class WechatGreetContentConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.GreetContentId;
             set => this.GreetContentId = value;
         }	

		 [Key]
		 public string GreetContentId {get;set;}

		 public string Content {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatNoInfo {get;set;}

	}
}
