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

		 public string UserOrderNo {get;set;}

		 public string UserName {get;set;}

		 public int ProduCategoryId {get;set;}

		 public int ProductId {get;set;}

		 public DateTime AuthorizationBeginTime {get;set;}

		 public DateTime AuthorizationEndTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public bool IsValid {get;set;}

		 public bool IsOrderUpdated {get;set;}

		 public DateTime OrderUpdatedTime {get;set;}

		 public bool IsGrantAuthority {get;set;}

		 public bool IsStop {get;set;}

		 public DateTime StopDate {get;set;}

	}
}
