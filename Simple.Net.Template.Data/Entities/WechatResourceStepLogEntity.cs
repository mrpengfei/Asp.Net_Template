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

		 public bool IsPull {get;set;}

		 public bool IsHasWechat {get;set;}

		 public bool IsAddWechatApply {get;set;}

		 public bool IsAddWechatSuccess {get;set;}

		 public bool IsDeleteWechat {get;set;}

		 public bool IsAddBlackList {get;set;}

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

		 public bool IsHandle {get;set;}

		 public DateTime HandleTime {get;set;}

	}
}
