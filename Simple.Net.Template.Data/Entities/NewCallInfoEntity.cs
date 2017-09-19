using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NewCallInfo")]
	public partial class NewCallInfoEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.NewCallInfoId;
             set => this.NewCallInfoId = value;
         }	

		 [Key]
		 public string NewCallInfoId {get;set;}

		 public string UserId {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateDate {get;set;}

	}
}
