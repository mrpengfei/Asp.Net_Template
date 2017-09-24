using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderLog")]
	public partial class UserOrderLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderLogId;
             set => this.UserOrderLogId = value;
         }	

		 [Key]
		 public int UserOrderLogId {get;set;}

		 public string UserOrderNo {get;set;}

		 public int EmployeeID {get;set;}

		 public bool OrderResult {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
