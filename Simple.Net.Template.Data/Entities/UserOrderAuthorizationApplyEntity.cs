using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderAuthorizationApply")]
	public partial class UserOrderAuthorizationApplyEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserOrderAuthorizationApplyId;
             set => this.UserOrderAuthorizationApplyId = value;
         }	

		 [Key]
		 public string UserOrderAuthorizationApplyId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public string StartDate {get;set;}

		 public string EndDate {get;set;}

 		 public override int Key
         {
             get => this.ServicesTypeId;
             set => this.ServicesTypeId = value;
         }	

		 [Key]
		 public string ServicesTypeId {get;set;}

 		 public override int Key
         {
             get => this.ApplyStateId;
             set => this.ApplyStateId = value;
         }	

		 [Key]
		 public string ApplyStateId {get;set;}

		 public string Description {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
