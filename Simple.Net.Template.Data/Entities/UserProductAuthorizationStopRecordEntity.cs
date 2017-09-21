using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserProductAuthorizationStopRecord")]
	public partial class UserProductAuthorizationStopRecordEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserProductAuthorizationStopRecordId;
             set => this.UserProductAuthorizationStopRecordId = value;
         }	

		 [Key]
		 public int UserProductAuthorizationStopRecordId {get;set;}

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

		 public string IsStop {get;set;}

		 public DateTime StopDate {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
