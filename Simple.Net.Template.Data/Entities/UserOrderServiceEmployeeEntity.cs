using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderServiceEmployee")]
	public partial class UserOrderServiceEmployeeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderServiceEmployeeId;
             set => this.UserOrderServiceEmployeeId = value;
         }	

		 [Key]
		 public int UserOrderServiceEmployeeId {get;set;}

		 public string UserOrderNo {get;set;}

		 public string UserId {get;set;}

		 public int ServiceEmployeeId {get;set;}

		 public int ServiceGroupId {get;set;}

		 public int ServiceDepartmentId {get;set;}

		 public int ServiceCompanyId {get;set;}

		 public bool IsConfirm {get;set;}

		 public DateTime ConfirmDate {get;set;}

		 public bool IsActive {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
