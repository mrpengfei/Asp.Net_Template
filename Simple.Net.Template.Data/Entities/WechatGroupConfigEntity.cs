using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupConfig")]
	public partial class WechatGroupConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatGroupConfigId;
             set => this.WechatGroupConfigId = value;
         }	

		 [Key]
		 public int WechatGroupConfigId {get;set;}

		 public string GroupName {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
