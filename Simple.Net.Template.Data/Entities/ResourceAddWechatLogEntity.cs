using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceAddWechatLog")]
	public partial class ResourceAddWechatLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceAddWechatLogId;
             set => this.ResourceAddWechatLogId = value;
         }	

		 [Key]
		 public string ResourceAddWechatLogId {get;set;}

		 public string WechatUin {get;set;}

		 public string ResourceId {get;set;}

		 public string AddType {get;set;}

		 public string AddWechatTime {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
