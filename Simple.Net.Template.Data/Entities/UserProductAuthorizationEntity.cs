using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserProductAuthorization")]
	public partial class UserProductAuthorizationEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserProductAuthorizationId;
             set => this.UserProductAuthorizationId = value;
         }	

		 [Key]
		 public int UserProductAuthorizationId {get;set;}

		 public string UserId {get;set;}

		 public int ProduCategoryId {get;set;}

		 public DateTime BeginTime {get;set;}

		 public DateTime EndTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public bool IsValid {get;set;}

		 public bool IsOrderUpdated {get;set;}

		 public DateTime OrderUpdatedTime {get;set;}

		 public bool IsGrantAuthority {get;set;}

		 public bool IsStop {get;set;}

		 public DateTime StopDate {get;set;}

	}
}
