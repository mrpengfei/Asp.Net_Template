using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatFilterResource")]
	public partial class WechatFilterResourceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatFilterResourceId;
             set => this.WechatFilterResourceId = value;
         }	

		 [Key]
		 public int WechatFilterResourceId {get;set;}

		 public int ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
