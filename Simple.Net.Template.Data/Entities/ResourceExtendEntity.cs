using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceExtend")]
	public partial class ResourceExtendEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceExtendId;
             set => this.ResourceExtendId = value;
         }	

		 [Key]
		 public int ResourceExtendId {get;set;}

		 public int ResourceId {get;set;}

		 public bool HasWechat {get;set;}

		 public bool AddWechat {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public int WechatGender {get;set;}

		 public bool IsPull {get;set;}

		 public bool IsAddWechat {get;set;}

	}
}
