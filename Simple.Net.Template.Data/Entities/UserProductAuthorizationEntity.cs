using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserProductAuthorization")]
	public partial class UserProductAuthorizationEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserProductAuthorizationId;
             set => this.UserProductAuthorizationId = value;
         }	

		 [Key]
		 public string UserProductAuthorizationId {get;set;}

 		 public override int Key
         {
             get => this.UserId;
             set => this.UserId = value;
         }	

		 [Key]
		 public string UserId {get;set;}

 		 public override int Key
         {
             get => this.ProduCategoryId;
             set => this.ProduCategoryId = value;
         }	

		 [Key]
		 public string ProduCategoryId {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string IsValid {get;set;}

		 public string IsOrderUpdated {get;set;}

		 public string OrderUpdatedTime {get;set;}

		 public string IsGrantAuthority {get;set;}

		 public string IsStop {get;set;}

		 public string StopDate {get;set;}

	}
}
