using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResourceApplyDetailLog")]
	public partial class WechatResourceApplyDetailLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatResourceApplyDetailLogId;
             set => this.WechatResourceApplyDetailLogId = value;
         }	

		 [Key]
		 public int WechatResourceApplyDetailLogId {get;set;}

		 public string WxUin {get;set;}

		 public int ResourceId {get;set;}

		 public int AddType {get;set;}

		 public string IsAddWechatApply {get;set;}

		 public string IsAddWechatSuccess {get;set;}

		 public DateTime AddWechatApplyTime {get;set;}

		 public DateTime AddWechatSuccessTime {get;set;}

		 public string IsActive {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
