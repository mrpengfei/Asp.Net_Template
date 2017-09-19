using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceReport")]
	public partial class ResourceReportEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.Id;
             set => this.Id = value;
         }	

		 [Key]
		 public string Id {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string EmployeeId {get;set;}

		 public string StaffId {get;set;}

		 public string TrueName {get;set;}

		 public string AssignCount {get;set;}

		 public string PullCount {get;set;}

		 public string UnPullCount {get;set;}

		 public string WechatPullCount {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string CompanyName {get;set;}

		 public string DepartmentName {get;set;}

		 public string GroupName {get;set;}

		 public string AddFriendCount {get;set;}

		 public string ReportDate {get;set;}

	}
}
