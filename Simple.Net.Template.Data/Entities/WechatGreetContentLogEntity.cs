using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGreetContentLog")]
	public partial class WechatGreetContentLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.GreetContentLogId;
             set => this.GreetContentLogId = value;
         }	

		 [Key]
		 public string GreetContentLogId {get;set;}

		 public string ResourceId {get;set;}

		 public string GreetContent {get;set;}

		 public string WechatUin {get;set;}

		 public string GreetTime {get;set;}

		 public string PassTime {get;set;}

		 public string IsPass {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
