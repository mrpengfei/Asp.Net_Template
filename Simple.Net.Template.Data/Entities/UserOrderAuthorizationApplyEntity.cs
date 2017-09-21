using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderAuthorizationApply")]
	public partial class UserOrderAuthorizationApplyEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderAuthorizationApplyId;
             set => this.UserOrderAuthorizationApplyId = value;
         }	

		 [Key]
		 public int UserOrderAuthorizationApplyId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public DateTime StartDate {get;set;}

		 public DateTime EndDate {get;set;}

 		 public override int Key
         {
             get => this.ServicesTypeId;
             set => this.ServicesTypeId = value;
         }	

		 [Key]
		 public int ServicesTypeId {get;set;}

 		 public override int Key
         {
             get => this.ApplyStateId;
             set => this.ApplyStateId = value;
         }	

		 [Key]
		 public int ApplyStateId {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
