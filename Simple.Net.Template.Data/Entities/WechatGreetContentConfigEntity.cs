using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGreetContentConfig")]
	public partial class WechatGreetContentConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.GreetContentId;
             set => this.GreetContentId = value;
         }	

		 [Key]
		 public int GreetContentId {get;set;}

		 public string Content {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatNoInfo {get;set;}

	}
}
