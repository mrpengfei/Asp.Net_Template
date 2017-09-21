using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatResource")]
	public partial class WechatResourceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatResourceId;
             set => this.WechatResourceId = value;
         }	

		 [Key]
		 public int WechatResourceId {get;set;}

		 public int ResourceId {get;set;}

		 public int EmployeeId {get;set;}

		 public string IsPull {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WechatUid {get;set;}

	}
}
