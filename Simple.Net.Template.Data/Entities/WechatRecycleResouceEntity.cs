using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatRecycleResouce")]
	public partial class WechatRecycleResouceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatRecycleResouceId;
             set => this.WechatRecycleResouceId = value;
         }	

		 [Key]
		 public int WechatRecycleResouceId {get;set;}

		 public int ResourceId {get;set;}

		 public int CompanyId {get;set;}

		 public int GroupId {get;set;}

		 public int DepartmentId {get;set;}

		 public int EmployeeId {get;set;}

		 public bool IsNew {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
