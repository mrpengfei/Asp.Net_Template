using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatHandledResourceLog")]
	public partial class WechatHandledResourceLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatHandledResourceLogId;
             set => this.WechatHandledResourceLogId = value;
         }	

		 [Key]
		 public string WechatHandledResourceLogId {get;set;}

		 public string ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public string PushTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
