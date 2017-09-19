using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderProductAuthorization")]
	public partial class UserOrderProductAuthorizationEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderProductAuthorizationId;
             set => this.UserOrderProductAuthorizationId = value;
         }	

		 [Key]
		 public string UserOrderProductAuthorizationId {get;set;}

 		 public override string Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

		 public string UserName {get;set;}

 		 public override string Key
         {
             get => this.ProduCategoryId;
             set => this.ProduCategoryId = value;
         }	

		 [Key]
		 public string ProduCategoryId {get;set;}

 		 public override string Key
         {
             get => this.ProductId;
             set => this.ProductId = value;
         }	

		 [Key]
		 public string ProductId {get;set;}

		 public string AuthorizationBeginTime {get;set;}

		 public string AuthorizationEndTime {get;set;}

		 public string CreateTime {get;set;}

		 public string IsValid {get;set;}

		 public string IsOrderUpdated {get;set;}

		 public string OrderUpdatedTime {get;set;}

		 public string IsGrantAuthority {get;set;}

		 public string IsStop {get;set;}

		 public string StopDate {get;set;}

	}
}
