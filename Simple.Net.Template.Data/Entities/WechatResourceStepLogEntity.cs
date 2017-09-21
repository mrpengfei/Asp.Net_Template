using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResourceStepLog")]
	public partial class WechatResourceStepLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatResourceStepLogId;
             set => this.WechatResourceStepLogId = value;
         }	

		 [Key]
		 public int WechatResourceStepLogId {get;set;}

		 public string WxUin {get;set;}

		 public int ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public string IsHasWechat {get;set;}

		 public string IsAddWechatApply {get;set;}

		 public string IsAddWechatSuccess {get;set;}

		 public string IsDeleteWechat {get;set;}

		 public string IsAddBlackList {get;set;}

		 public DateTime PullTime {get;set;}

		 public DateTime AddWechatApplyTime {get;set;}

		 public DateTime AddWechatSuccessTime {get;set;}

		 public DateTime DeleteWechatTime {get;set;}

		 public DateTime AddBlackListTime {get;set;}

		 public DateTime LastRelationTime {get;set;}

		 public DateTime LastSendMessageTime {get;set;}

		 public DateTime LastAcceptMessageTime {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int AddType {get;set;}

		 public string IsHandle {get;set;}

		 public DateTime HandleTime {get;set;}

	}
}
