using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceAddWechatLog")]
	public partial class ResourceAddWechatLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceAddWechatLogId;
             set => this.ResourceAddWechatLogId = value;
         }	

		 [Key]
		 public int ResourceAddWechatLogId {get;set;}

		 public string WechatUin {get;set;}

		 public int ResourceId {get;set;}

		 public int AddType {get;set;}

		 public DateTime AddWechatTime {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
