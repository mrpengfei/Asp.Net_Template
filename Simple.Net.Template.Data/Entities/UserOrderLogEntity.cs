using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderLog")]
	public partial class UserOrderLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderLogId;
             set => this.UserOrderLogId = value;
         }	

		 [Key]
		 public string UserOrderLogId {get;set;}

 		 public override string Key
         {
             get => this.UserOrderNo;
             set => this.UserOrderNo = value;
         }	

		 [Key]
		 public string UserOrderNo {get;set;}

 		 public override string Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public string EmployeeID {get;set;}

		 public string OrderResult {get;set;}

		 public string Description {get;set;}

		 public string CreateTime {get;set;}

	}
}
