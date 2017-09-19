using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGroupConfig")]
	public partial class WechatGroupConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatGroupConfigId;
             set => this.WechatGroupConfigId = value;
         }	

		 [Key]
		 public string WechatGroupConfigId {get;set;}

		 public string GroupName {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
