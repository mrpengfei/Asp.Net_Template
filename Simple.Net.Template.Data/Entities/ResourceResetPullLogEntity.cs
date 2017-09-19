using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceResetPullLog")]
	public partial class ResourceResetPullLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ResourceResetPullLogId;
             set => this.ResourceResetPullLogId = value;
         }	

		 [Key]
		 public string ResourceResetPullLogId {get;set;}

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

		 public string ResetPullDate {get;set;}

		 public string ResetPullReason {get;set;}

		 public string OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string TaskId {get;set;}

	}
}
