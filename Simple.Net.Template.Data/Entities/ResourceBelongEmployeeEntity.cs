using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceBelongEmployee")]
	public partial class ResourceBelongEmployeeEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.BelongID;
             set => this.BelongID = value;
         }	

		 [Key]
		 public string BelongID {get;set;}

		 public string ResourceId {get;set;}

		 public string BelongEmployeeId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string BelongType {get;set;}

		 public string UserId {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string BelongStaffId {get;set;}

		 public string TrueName {get;set;}

	}
}
