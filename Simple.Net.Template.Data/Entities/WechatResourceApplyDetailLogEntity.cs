using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResourceApplyDetailLog")]
	public partial class WechatResourceApplyDetailLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatResourceApplyDetailLogId;
             set => this.WechatResourceApplyDetailLogId = value;
         }	

		 [Key]
		 public string WechatResourceApplyDetailLogId {get;set;}

		 public string WxUin {get;set;}

		 public string ResourceId {get;set;}

		 public string AddType {get;set;}

		 public string IsAddWechatApply {get;set;}

		 public string IsAddWechatSuccess {get;set;}

		 public string AddWechatApplyTime {get;set;}

		 public string AddWechatSuccessTime {get;set;}

		 public string IsActive {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
