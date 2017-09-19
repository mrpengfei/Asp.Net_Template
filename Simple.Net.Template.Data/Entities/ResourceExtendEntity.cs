using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceExtend")]
	public partial class ResourceExtendEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceExtendId;
             set => this.ResourceExtendId = value;
         }	

		 [Key]
		 public string ResourceExtendId {get;set;}

		 public string ResourceId {get;set;}

		 public string HasWechat {get;set;}

		 public string AddWechat {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string WechatGender {get;set;}

		 public string IsPull {get;set;}

		 public string IsAddWechat {get;set;}

	}
}
