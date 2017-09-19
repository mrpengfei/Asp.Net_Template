using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderServiceEmployee")]
	public partial class UserOrderServiceEmployeeEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderServiceEmployeeId;
             set => this.UserOrderServiceEmployeeId = value;
         }	

		 [Key]
		 public string UserOrderServiceEmployeeId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public string ServiceEmployeeId {get;set;}

		 public string ServiceGroupId {get;set;}

		 public string ServiceDepartmentId {get;set;}

		 public string ServiceCompanyId {get;set;}

		 public string IsConfirm {get;set;}

		 public string ConfirmDate {get;set;}

		 public string IsActive {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
