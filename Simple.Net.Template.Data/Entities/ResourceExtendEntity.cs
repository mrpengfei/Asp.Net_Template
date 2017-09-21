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

		 public string HasWechat {get;set;}

		 public string AddWechat {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public int WechatGender {get;set;}

		 public string IsPull {get;set;}

		 public string IsAddWechat {get;set;}

	}
}
