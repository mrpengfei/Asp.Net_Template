using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderProductAuthorization")]
	public partial class UserOrderProductAuthorizationEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderProductAuthorizationId;
             set => this.UserOrderProductAuthorizationId = value;
         }	

		 [Key]
		 public int UserOrderProductAuthorizationId {get;set;}

 		 public override int Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

		 public string UserName {get;set;}

 		 public override int Key
         {
             get => this.ProduCategoryId;
             set => this.ProduCategoryId = value;
         }	

		 [Key]
		 public int ProduCategoryId {get;set;}

 		 public override int Key
         {
             get => this.ProductId;
             set => this.ProductId = value;
         }	

		 [Key]
		 public int ProductId {get;set;}

		 public DateTime AuthorizationBeginTime {get;set;}

		 public DateTime AuthorizationEndTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public string IsValid {get;set;}

		 public string IsOrderUpdated {get;set;}

		 public DateTime OrderUpdatedTime {get;set;}

		 public string IsGrantAuthority {get;set;}

		 public string IsStop {get;set;}

		 public DateTime StopDate {get;set;}

	}
}
