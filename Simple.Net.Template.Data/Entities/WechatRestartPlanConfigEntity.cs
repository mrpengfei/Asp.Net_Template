using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatRestartPlanConfig")]
	public partial class WechatRestartPlanConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatRestartPlanId;
             set => this.WechatRestartPlanId = value;
         }	

		 [Key]
		 public int WechatRestartPlanId {get;set;}

		 public int RestartMinutes {get;set;}

		 public int RestartSeconds {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
