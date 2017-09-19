using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatFilterResource")]
	public partial class WechatFilterResourceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatFilterResourceId;
             set => this.WechatFilterResourceId = value;
         }	

		 [Key]
		 public string WechatFilterResourceId {get;set;}

		 public string ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
