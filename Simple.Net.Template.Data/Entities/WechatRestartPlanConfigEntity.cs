using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatRestartPlanConfig")]
	public partial class WechatRestartPlanConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatRestartPlanId;
             set => this.WechatRestartPlanId = value;
         }	

		 [Key]
		 public string WechatRestartPlanId {get;set;}

		 public string RestartMinutes {get;set;}

		 public string RestartSeconds {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
