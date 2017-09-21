using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatGreetContentLog")]
	public partial class WechatGreetContentLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.GreetContentLogId;
             set => this.GreetContentLogId = value;
         }	

		 [Key]
		 public int GreetContentLogId {get;set;}

		 public int ResourceId {get;set;}

		 public string GreetContent {get;set;}

		 public string WechatUin {get;set;}

		 public DateTime GreetTime {get;set;}

		 public DateTime PassTime {get;set;}

		 public string IsPass {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
