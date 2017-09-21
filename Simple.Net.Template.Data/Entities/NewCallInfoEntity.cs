using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NewCallInfo")]
	public partial class NewCallInfoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.NewCallInfoId;
             set => this.NewCallInfoId = value;
         }	

		 [Key]
		 public int NewCallInfoId {get;set;}

		 public string UserId {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
