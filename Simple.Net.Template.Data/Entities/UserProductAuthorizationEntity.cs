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
		 public int ProduCategoryId {get;set;}

		 public DateTime BeginTime {get;set;}

		 public DateTime EndTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string IsValid {get;set;}

		 public string IsOrderUpdated {get;set;}

		 public DateTime OrderUpdatedTime {get;set;}

		 public string IsGrantAuthority {get;set;}

		 public string IsStop {get;set;}

		 public DateTime StopDate {get;set;}

	}
}
