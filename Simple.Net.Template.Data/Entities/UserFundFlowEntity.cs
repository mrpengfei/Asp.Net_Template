using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserFundFlow")]
	public partial class UserFundFlowEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserFundFlowId;
             set => this.UserFundFlowId = value;
         }	

		 [Key]
		 public int UserFundFlowId {get;set;}

		 public string UserId {get;set;}

		 public string FlowMoney {get;set;}

		 public int FlowType {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
