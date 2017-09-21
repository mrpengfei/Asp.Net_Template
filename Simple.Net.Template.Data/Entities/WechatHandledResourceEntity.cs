using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatHandledResource")]
	public partial class WechatHandledResourceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatHandledResourceId;
             set => this.WechatHandledResourceId = value;
         }	

		 [Key]
		 public int WechatHandledResourceId {get;set;}

		 public int ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
