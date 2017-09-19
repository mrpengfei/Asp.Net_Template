using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TianYiAPP")]
	public partial class TianYiAPPEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.TianYiAPPId;
             set => this.TianYiAPPId = value;
         }	

		 [Key]
		 public string TianYiAPPId {get;set;}

		 public string APPVersion {get;set;}

		 public string APPType {get;set;}

		 public string IsNeedUpdate {get;set;}

		 public string APPUrl {get;set;}

		 public string VersionDescription {get;set;}

		 public string SupportWechatVersion {get;set;}

		 public string PublishDate {get;set;}

	}
}
