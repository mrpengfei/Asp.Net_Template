using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TianYiAPP")]
	public partial class TianYiAPPEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.TianYiAPPId;
             set => this.TianYiAPPId = value;
         }	

		 [Key]
		 public int TianYiAPPId {get;set;}

		 public string APPVersion {get;set;}

		 public int APPType {get;set;}

		 public bool IsNeedUpdate {get;set;}

		 public string APPUrl {get;set;}

		 public string VersionDescription {get;set;}

		 public string SupportWechatVersion {get;set;}

		 public DateTime PublishDate {get;set;}

	}
}
