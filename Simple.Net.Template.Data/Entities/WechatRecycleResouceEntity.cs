using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatRecycleResouce")]
	public partial class WechatRecycleResouceEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WechatRecycleResouceId;
             set => this.WechatRecycleResouceId = value;
         }	

		 [Key]
		 public string WechatRecycleResouceId {get;set;}

		 public string ResourceId {get;set;}

		 public string CompanyId {get;set;}

		 public string GroupId {get;set;}

		 public string DepartmentId {get;set;}

		 public string EmployeeId {get;set;}

		 public string IsNew {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
