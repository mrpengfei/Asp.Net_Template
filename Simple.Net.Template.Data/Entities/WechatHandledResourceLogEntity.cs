using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatHandledResourceLog")]
	public partial class WechatHandledResourceLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatHandledResourceLogId;
             set => this.WechatHandledResourceLogId = value;
         }	

		 [Key]
		 public int WechatHandledResourceLogId {get;set;}

		 public int ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public DateTime PushTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
