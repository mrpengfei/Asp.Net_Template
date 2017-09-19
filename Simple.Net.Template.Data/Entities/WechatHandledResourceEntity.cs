using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatHandledResource")]
	public partial class WechatHandledResourceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatHandledResourceId;
             set => this.WechatHandledResourceId = value;
         }	

		 [Key]
		 public string WechatHandledResourceId {get;set;}

		 public string ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
