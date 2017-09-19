using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResourceStepLog_bak")]
	public partial class WechatResourceStepLog_bakEntity : BaseEntity
	{
		 public string WechatResourceStepLogId {get;set;}

		 public string WxUin {get;set;}

		 public string ResourceId {get;set;}

		 public string IsPull {get;set;}

		 public string IsHasWechat {get;set;}

		 public string IsAddWechatApply {get;set;}

		 public string IsAddWechatSuccess {get;set;}

		 public string IsDeleteWechat {get;set;}

		 public string IsAddBlackList {get;set;}

		 public string PullTime {get;set;}

		 public string AddWechatApplyTime {get;set;}

		 public string AddWechatSuccessTime {get;set;}

		 public string DeleteWechatTime {get;set;}

		 public string AddBlackListTime {get;set;}

		 public string LastRelationTime {get;set;}

		 public string LastSendMessageTime {get;set;}

		 public string LastAcceptMessageTime {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string AddType {get;set;}

		 public string IsHandle {get;set;}

		 public string HandleTime {get;set;}

		 public string OldResourceID {get;set;}

		 public string NewResourceID {get;set;}

		 public string NewIsAddWechatSuccess {get;set;}

		 public string NewAddWechatSuccessTime {get;set;}

	}
}
