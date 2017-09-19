using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserProductAuthorizationStopRecord")]
	public partial class UserProductAuthorizationStopRecordEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserProductAuthorizationStopRecordId;
             set => this.UserProductAuthorizationStopRecordId = value;
         }	

		 [Key]
		 public string UserProductAuthorizationStopRecordId {get;set;}

		 public string UserId {get;set;}

 		 public override string Key
         {
             get => this.ProduCategoryId;
             set => this.ProduCategoryId = value;
         }	

		 [Key]
		 public string ProduCategoryId {get;set;}

		 public string BeginTime {get;set;}

		 public string EndTime {get;set;}

		 public string IsStop {get;set;}

		 public string StopDate {get;set;}

		 public string Description {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
