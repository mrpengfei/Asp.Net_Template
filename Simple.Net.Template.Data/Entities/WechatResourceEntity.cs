using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResource")]
	public partial class WechatResourceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatResourceId;
             set => this.WechatResourceId = value;
         }	

		 [Key]
		 public string WechatResourceId {get;set;}

		 public string ResourceId {get;set;}

		 public string EmployeeId {get;set;}

		 public string IsPull {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
