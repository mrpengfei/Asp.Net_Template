using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceReport")]
	public partial class ResourceReportEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.Id;
             set => this.Id = value;
         }	

		 [Key]
		 public int Id {get;set;}

		 public int CompanyId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public string StaffId {get;set;}

		 public string TrueName {get;set;}

		 public int AssignCount {get;set;}

		 public int PullCount {get;set;}

		 public int UnPullCount {get;set;}

		 public int WechatPullCount {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string CompanyName {get;set;}

		 public string DepartmentName {get;set;}

		 public string GroupName {get;set;}

		 public int AddFriendCount {get;set;}

		 public DateTime ReportDate {get;set;}

	}
}
