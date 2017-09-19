using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceRecycleLog")]
	public partial class ResourceRecycleLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceRecycleLogId;
             set => this.ResourceRecycleLogId = value;
         }	

		 [Key]
		 public string ResourceRecycleLogId {get;set;}

		 public string ResourceId {get;set;}

		 public string WechatUin {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string EmployeeId {get;set;}

		 public string PullTime {get;set;}

		 public string HasWechat {get;set;}

		 public string IsAddWechat {get;set;}

		 public string AddWechatTime {get;set;}

		 public string ResourceTypeId {get;set;}

		 public string ResourceSubTypeId {get;set;}

		 public string RecycleDate {get;set;}

		 public string RecycleReason {get;set;}

		 public string OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
