using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderInAccountApply")]
	public partial class UserOrderInAccountApplyEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserOrderInAccountApplyId;
             set => this.UserOrderInAccountApplyId = value;
         }	

		 [Key]
		 public string UserOrderInAccountApplyId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public string IncomeMoney {get;set;}

 		 public override int Key
         {
             get => this.AccountTypeId;
             set => this.AccountTypeId = value;
         }	

		 [Key]
		 public string AccountTypeId {get;set;}

 		 public override int Key
         {
             get => this.ApplyStateId;
             set => this.ApplyStateId = value;
         }	

		 [Key]
		 public string ApplyStateId {get;set;}

		 public string Description {get;set;}

		 public string AccountDetail {get;set;}

		 public string RefusalReason {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string UserInAccountApplyId {get;set;}

	}
}
