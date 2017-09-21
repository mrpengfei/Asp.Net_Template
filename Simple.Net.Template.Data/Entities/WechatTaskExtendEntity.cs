using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatTaskExtend")]
	public partial class WechatTaskExtendEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatTaskExtendId;
             set => this.WechatTaskExtendId = value;
         }	

		 [Key]
		 public int WechatTaskExtendId {get;set;}

		 public int MainTaskId {get;set;}

		 public string WxUin {get;set;}

		 public int ExtendCount {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int WechatGroupConfigId {get;set;}

	}
}
