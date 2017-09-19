using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserFundFlow")]
	public partial class UserFundFlowEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserFundFlowId;
             set => this.UserFundFlowId = value;
         }	

		 [Key]
		 public string UserFundFlowId {get;set;}

		 public string UserId {get;set;}

		 public string FlowMoney {get;set;}

		 public string FlowType {get;set;}

		 public string Description {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
